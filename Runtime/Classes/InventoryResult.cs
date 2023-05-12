using System;
using Steamworks.Data;

namespace Steamworks
{
	public class InventoryResult
	{
		internal SteamInventoryResult_t _id;
		
		public Result          Result  { get; }
		public bool            Success => Result == Result.OK;
		public bool            Expired => Result == Result.Expired;
        public InventoryItem[] Items   { get; }

		internal InventoryResult( SteamInventoryResult_t id, Result result )
		{
			_id    = id;
			Result = result;
			if ( Success || Expired )
				Items = GetItems();
			else
				Items = Array.Empty<InventoryItem>();
		}

		internal int ItemCount
		{
			get
			{
				uint cnt = 0;

				if ( !SteamInventory.Internal.GetResultItems( _id, null, ref cnt ) )
					return 0;

				return (int) cnt;
			}
		}

        ~InventoryResult() {
            SteamInventory.Internal.DestroyResult( _id );
        }

		/// <summary>
		/// Checks whether an inventory result handle belongs to the specified Steam ID.
		/// This is important when using Deserialize, to verify that a remote player is not pretending to have a different user's inventory
		/// </summary>
		public bool BelongsTo( SteamId steamId )
		{
			return SteamInventory.Internal.CheckResultSteamID( _id, steamId );
		}

        internal InventoryItem[] GetItems( bool includeProperties = false )
		{
			uint cnt = (uint) ItemCount;
			if ( cnt <= 0 ) return null;

			var pOutItemsArray = new SteamItemDetails_t[cnt];

			if ( !SteamInventory.Internal.GetResultItems( _id, pOutItemsArray, ref cnt ) )
				return null;

			var items = new InventoryItem[cnt];

			for( int i=0; i< cnt; i++ )
			{
				var item = InventoryItem.From( pOutItemsArray[i] );

				if ( includeProperties )
					item._properties = InventoryItem.GetProperties( _id, i );

				items[i] = item;
			}


			return items;			
		}

        /// <summary>
		/// Serialized result sets contain a short signature which can't be forged or replayed across different game sessions.
		/// A result set can be serialized on the local client, transmitted to other players via your game networking, and 
		/// deserialized by the remote players.This is a secure way of preventing hackers from lying about posessing 
		/// rare/high-value items. Serializes a result set with signature bytes to an output buffer.The size of a serialized 
		/// result depends on the number items which are being serialized.When securely transmitting items to other players, 
		/// it is recommended to use GetItemsByID first to create a minimal result set.
		/// Results have a built-in timestamp which will be considered "expired" after an hour has elapsed.See DeserializeResult
		/// for expiration handling.
		/// </summary>
		public unsafe byte[] Serialize()
		{
			uint size = 0;

			if ( !SteamInventory.Internal.SerializeResult( _id, IntPtr.Zero, ref size ) )
				return null;

			var data = new byte[size];

			fixed ( byte* ptr = data )
			{
				if ( !SteamInventory.Internal.SerializeResult( _id, (IntPtr)ptr, ref size ) )
					return null;
			}

			return data;
		}
	}
}
