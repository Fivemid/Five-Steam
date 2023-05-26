using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	/// <summary>
	/// Class for utilizing the Steam Inventory API.
	/// </summary>
	public class SteamInventory : SteamSharedClass<SteamInventory>
	{
		internal static ISteamInventory Internal => Interface as ISteamInventory;

		internal override bool InitializeInterface( bool server )
		{
			SetInterface( server, new ISteamInventory( server ) );
			if ( Interface.Self == IntPtr.Zero ) return false;

			InstallEvents( server );
			ResetState();
			if ( !server )
				SteamUser.OnMicroTxnAuthorizationResponse += OnTransactionConfirm;

			return true;
		}

		internal override void DestroyInterface( bool server )
		{
			base.DestroyInterface( server );
			if ( !server )
				SteamUser.OnMicroTxnAuthorizationResponse -= OnTransactionConfirm;
		}

		internal static void InstallEvents( bool server )
		{
			Dispatch.Install<SteamInventoryResultReady_t>( OnInventoryResultReady, server );
			Dispatch.Install<SteamInventoryDefinitionUpdate_t>( OnDefinitionsUpdate, server );
		}

		private void ResetState()
		{
			Items               = new();
			Definitions         = new();
			callbacks           = new();
			definitionsCallback = null;
		}

		private static void OnInventoryResultReady( SteamInventoryResultReady_t x )
		{
			InventoryResult result = new(x.Handle, x.Result);
			if ( callbacks.ContainsKey( x.Handle ) )
			{
				callbacks[x.Handle].Invoke( result );
				callbacks.Remove( x.Handle );
			}
		}

		private static void OnDefinitionsUpdate( SteamInventoryDefinitionUpdate_t x )
		{
			SetDefinitions();
			definitionsCallback?.Invoke();
			OnDefinitionsUpdated?.Invoke();
		}

		private static async void OnTransactionConfirm( AppId appId, ulong orderId, bool confirm )
		{
			if ( appId == SteamClient.AppId )
				await GetAllItemsAsync();
		}

		/// <summary>
		/// We will try to keep this list of your items automatically up to date.
		/// </summary>
		public static Dictionary<InventoryItemId, InventoryItem> Items { get; internal set; }

		public static Dictionary<InventoryDefId, InventoryDef> Definitions { get; internal set; }

		private static Dictionary<SteamInventoryResult_t, Action<InventoryResult>> callbacks = new();
		private static Action                                                      definitionsCallback;

		public static event Action OnInventoryUpdated;
		public static event Action OnDefinitionsUpdated;

		private static void RegisterCallback( SteamInventoryResult_t handle, Action<InventoryResult> callback )
		{
			if ( callbacks.ContainsKey( handle ) )
				callbacks[handle] += callback;
			else
				callbacks[handle] = callback;
		}

		private static void UpdateSelfInventoryCallback( InventoryResult result )
		{
			if ( !result.Success ) return;
			foreach ( InventoryItem resultItem in result.Items )
			{
				if ( resultItem.Quantity == 0 )
				{
					Items.Remove( resultItem.Id );
				}
				else
				{
					Items[resultItem.Id] = resultItem;
				}
			}

			OnInventoryUpdated?.Invoke();
		}

		private static void SetDefinitions()
		{
			Definitions.Clear();
			foreach ( InventoryDef definition in GetDefinitions() ?? Array.Empty<InventoryDef>() )
			{
				Definitions.Add( definition.Id, definition );
			}
		}

		public static Task EnsureDefinitionsLoadedAsync()
		{
			var promise = new TaskCompletionSource<bool>();

			if ( Definitions.Count > 0 )
				return Task.CompletedTask;
			SetDefinitions();
			if ( Definitions.Count > 0 )
				return Task.CompletedTask;

			void Callback()
			{
				promise.SetResult( true );
				definitionsCallback -= Callback;
			}

			definitionsCallback += Callback;
			Internal.LoadItemDefinitions();
			return promise.Task;
		}

		public static async Task RequestPricesAsync()
		{
			var resultOpt = await Internal.RequestPrices();
			if ( resultOpt is not { Result: Result.OK } result )
			{
				throw new Exception( $"Request prices failed: {resultOpt}" );
			}

			Currency = result.CurrencyUTF8();
		}

		public static string Currency { get; internal set; }

		internal static InventoryDef[] GetDefinitions()
		{
			uint num = 0;
			if ( !Internal.GetItemDefinitionIDs( null, ref num ) )
				return null;

			var defs = new InventoryDefId[num];

			if ( !Internal.GetItemDefinitionIDs( defs, ref num ) )
				return null;

			return defs.Select( x => new InventoryDef( x ) ).ToArray();
		}

		internal static Task<InventoryResult> GetAsync( SteamInventoryResult_t handle, bool updateSelfInventory = true )
		{
			var promise = new TaskCompletionSource<InventoryResult>();
			RegisterCallback( handle, result => {
                if ( updateSelfInventory )
                    UpdateSelfInventoryCallback( result );
				if ( result.Success )
					promise.TrySetResult( result );
				else
					promise.TrySetException( new Exception( $"Inventory Operation failed: {result.Result}" ) );
			} );
			return promise.Task;
		}

		/// <summary>
		/// Get all items and return the InventoryResult
		/// </summary>
		public static async Task<InventoryResult> GetAllItemsAsync()
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			if ( !Internal.GetAllItems( ref handle ) )
				return null;

			return await GetAsync( handle );
		}

		/// <summary>
		/// This is used to grant a specific item to the user. This should 
		/// only be used for development prototyping, from a trusted server, 
		/// or if you don't care about hacked clients granting arbitrary items. 
		/// This call can be disabled by a setting on Steamworks.
		/// </summary>
		public static async Task<InventoryResult> GenerateItemAsync( InventoryDef target, int amount )
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			var defs = new InventoryDefId[] { target.Id };
			var cnts = new uint[] { (uint)amount };

			if ( !Internal.GenerateItems( ref handle, defs, cnts, 1 ) )
				return null;

			return await GetAsync( handle );
		}

		/// <summary>
		/// Crafting! Uses the passed items to buy the target item.
		/// You need to have set up the appropriate exchange rules in your item
		/// definitions. This assumes all the items passed in aren't stacked.
		/// </summary>
		public static async Task<InventoryResult> CraftItemAsync( InventoryItem[] list, InventoryDef target )
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			var give  = new InventoryDefId[] { target.Id };
			var givec = new uint[] { 1 };

			var sell  = list.Select( x => x.Id ).ToArray();
			var sellc = list.Select( x => (uint)1 ).ToArray();

			if ( !Internal.ExchangeItems( ref handle, give, givec, 1, sell, sellc, (uint)sell.Length ) )
				return null;

			return await GetAsync( handle );
		}

		/// <summary>
		/// Crafting! Uses the passed items to buy the target item.
		/// You need to have set up the appropriate exchange rules in your item
		/// definitions. This assumes all the items passed in aren't stacked.
		/// </summary>
		public static async Task<InventoryResult> CraftItemAsync( InventoryItem.Amount[] list, InventoryDef target )
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			var give  = new InventoryDefId[] { target.Id };
			var givec = new uint[] { 1 };

			var sell  = list.Select( x => x.Item.Id ).ToArray();
			var sellc = list.Select( x => (uint)x.Quantity ).ToArray();

			if ( !Internal.ExchangeItems( ref handle, give, givec, 1, sell, sellc, (uint)sell.Length ) )
				return null;

			return await GetAsync( handle );
		}

		/// <summary>
		/// Deserializes a result set and verifies the signature bytes.	
		/// This call has a potential soft-failure mode where the Result is expired, it will 
		/// still succeed in this mode.The "expired" 
		/// result could indicate that the data may be out of date - not just due to timed 
		/// expiration( one hour ), but also because one of the items in the result set may 
		/// have been traded or consumed since the result set was generated.You could compare 
		/// the timestamp from GetResultTimestamp to ISteamUtils::GetServerRealTime to determine
		/// how old the data is. You could simply ignore the "expired" result code and 
		/// continue as normal, or you could request the player with expired data to send 
		/// an updated result set.
		/// You should call CheckResultSteamID on the result handle when it completes to verify 
		/// that a remote player is not pretending to have a different user's inventory.
		/// </summary>
		public static async Task<InventoryResult> DeserializeAsync( byte[] data, int dataLength = -1 )
		{
			if ( data == null )
				throw new ArgumentException( "data should not be null" );

			if ( dataLength == -1 )
				dataLength = data.Length;

			var ptr = Marshal.AllocHGlobal( dataLength );

			try
			{
				Marshal.Copy( data, 0, ptr, dataLength );

				var handle = Defines.k_SteamInventoryResultInvalid;

				if ( !Internal.DeserializeResult( ref handle, ptr, (uint)dataLength, false ) )
					return null;


				return await GetAsync( handle, updateSelfInventory: false );
			}
			finally
			{
				Marshal.FreeHGlobal( ptr );
			}
		}


		/// <summary>
		/// Grant all promotional items the user is eligible for.
		/// </summary>
		public static async Task<InventoryResult> GrantPromoItemsAsync()
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			if ( !Internal.GrantPromoItems( ref handle ) )
				return null;

			return await GetAsync( handle );
		}


		/// <summary>
		/// Trigger an item drop for this user. This is for timed drops.
		/// </summary>
		public static async Task<InventoryResult> TriggerItemDropAsync( InventoryDefId id )
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			if ( !Internal.TriggerItemDrop( ref handle, id ) )
				return null;

			return await GetAsync( handle );
		}

		/// <summary>
		/// Trigger a promo item drop. You can call this at startup, it won't
		/// give users multiple promo drops.
		/// </summary>
		public static async Task<InventoryResult> AddPromoItemAsync( InventoryDefId id )
		{
			var handle = Defines.k_SteamInventoryResultInvalid;

			if ( !Internal.AddPromoItem( ref handle, id ) )
				return null;

			return await GetAsync( handle );
		}


		/// <summary>
		/// Start buying a cart load of items. This will return a positive result is the purchase has
		/// begun. You should listen out for SteamUser.OnMicroTxnAuthorizationResponse for a success.
		/// </summary>
		public static async Task<InventoryPurchaseResult?> StartPurchaseAsync( InventoryDef[] items )
		{
			var d      = items.GroupBy( x => x._id ).ToDictionary( x => x.Key, x => (uint)x.Count() );
			var item_i = d.Keys.ToArray();
			var item_q = d.Values.ToArray();

			var r = await Internal.StartPurchase( item_i, item_q, (uint)item_i.Length );
			if ( !r.HasValue ) return null;

			return new InventoryPurchaseResult
			{
				Result = r.Value.Result, OrderID = r.Value.OrderID, TransID = r.Value.TransID
			};
		}

		public static async Task<InventoryDefId[]> GetEligiblePromoItemDefinitionIDs()
		{
			var resultOpt = await Internal.RequestEligiblePromoItemDefinitionsIDs( SteamClient.SteamId );
			if ( resultOpt is not { } result ) return null;
			var results = new InventoryDefId[result.UmEligiblePromoItemDefs];
			var size    = (uint)results.Length;
			return Internal.GetEligiblePromoItemDefinitionIDs( result.SteamID, results, ref size )
				       ? results
				       : null;
		}

		public static InventoryDef GetDefinition( InventoryDefId defId ) =>
			Definitions.TryGetValue( defId, out var definition )
				? definition
				: null;
	}
}
