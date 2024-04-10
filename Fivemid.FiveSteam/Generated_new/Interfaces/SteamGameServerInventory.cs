using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerInventory
    {
        public static ISteamInventory.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServerInventory_v003", CallingConvention = Platform.CC)]
        private static extern ISteamInventory.Instance Accessor();
        /// <summary>
        /// <code>EResult GetResultStatus( SteamInventoryResult_t resultHandle );</code>
        /// 
        /// <br />
        /// Find out the status of an asynchronous inventory result handle.<br />
        /// <br />
        /// This is a polling equivalent to registering a callback function for
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryResultReady_t" class="bb_apilink">SteamInventoryResultReady_t</a>.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EResult" class="bb_apilink">EResult</a><br />
        /// Whether the call was successful or not.<br />
        /// <br />
        /// Possible values:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultPending" class="bb_apilink">k_EResultPending</a>
        ///         - Still in progress.<br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///         - Done, the request has completed successfully and the result is ready.<br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultExpired" class="bb_apilink">k_EResultExpired</a>
        ///         - Done, result ready, maybe out of date (see DeserializeResult)<br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>
        ///         - ERROR: Invalid API call parameters.<br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultServiceUnavailable" class="bb_apilink">k_EResultServiceUnavailable</a>
        ///         - ERROR: Service temporarily down, you may retry later.<br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultLimitExceeded" class="bb_apilink">k_EResultLimitExceeded</a>
        ///         - ERROR: Operation would exceed per-user inventory limits.<br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>
        ///         - ERROR: Generic error.
        ///     </li>
        /// </ul>
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void SpaceWarItem::CheckInventory( IGameEngine *pGameEngine ) { if ( s_RequestResult != 0 ) {
        ///     EResult result = SteamInventory()-&gt;GetResultStatus( s_RequestResult ); if ( result ==
        ///     k_EResultOK ) { // Do something here } } }
        /// </code>
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The inventory result handle to get the status for.</param>
        public static Result GetResultStatus(SteamInventoryResult resultHandle) => Instance.GetResultStatus(resultHandle);
        /// <summary>
        /// <code>
        ///     bool GetResultItems( SteamInventoryResult_t resultHandle, SteamItemDetails_t *pOutItemsArray,
        ///     uint32 *punOutItemsArraySize );
        /// </code>
        /// 
        /// <br />
        /// Get the items associated with an inventory result handle.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the call was successful, otherwise <b>false</b>.<br />
        /// Potential failure reasons include:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">resultHandle</code> is invalid or the
        ///         inventory result handle is not ready.<br />
        ///     </li>
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">pOutItemsArray</code> is not large enough
        ///         to hold the array.<br />
        ///     </li>
        ///     <li>The user has no items.</li>
        /// </ul>
        /// <br />
        /// If the call is successful then
        /// <code class="bb_code bb_code_inline nohighlight">punItemDefIDsArraySize</code> will contain the
        /// number of item definitions available.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     bool bGotResult = false; std::vector&lt;SteamItemDetails_t&gt; vecDetails; uint32 count = 0; if
        ///     ( SteamInventory()-&gt;GetResultItems( callback-&gt;m_handle, NULL, &amp;count ) ) {
        ///     vecDetails.resize( count ); bGotResult = SteamInventory()-&gt;GetResultItems(
        ///     callback-&gt;m_handle, vecDetails.data(), &amp;count ); }
        /// </code>
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The inventory result handle to get the items for.</param>
        /// <param name="pOutItemsArray">SteamItemDetails_t
        ///             *: The details are returned by copying them into this array.</param>
        /// <param name="punOutItemsArraySize">uint32
        ///             *: 
        ///             This should be set to the length of
        ///             <code class="bb_code bb_code_inline nohighlight">pOutItemsArray</code>. If
        ///             <code class="bb_code bb_code_inline nohighlight">pOutItemsArray</code> is
        ///             <b>NULL</b> then this will return the number of elements the array needs to
        ///             hold.
        ///         </param>
        public static bool GetResultItems(SteamInventoryResult resultHandle, SteamItemDetails* pOutItemsArray, uint* punOutItemsArraySize) => Instance.GetResultItems(resultHandle, pOutItemsArray, punOutItemsArraySize);
        /// <summary>
        /// <code>
        ///     bool GetResultItemProperty( SteamInventoryResult_t resultHandle, uint32 unItemIndex, const char
        ///     *pchPropertyName, char *pchValueBuffer, uint32 *punValueBufferSizeOut );
        /// </code>
        /// 
        /// <br />
        /// Gets the dynamic properties from an item in an inventory result set.<br />
        /// <br />
        /// Property names are always composed of ASCII letters, numbers, and/or underscores.<br />
        /// <br />
        /// If the results do not fit in the given buffer, partial results may be copied.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This returns <b>true</b> upon success; otherwise, <b>false</b> indicating that
        /// the inventory result handle was invalid or the provided index does not contain an item.
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The result handle containing the item to get the properties of.</param>
        /// <param name="unItemIndex">uint32: </param>
        /// <param name="pchPropertyName">const char *: 
        ///             The property name to get the value for. If you pass in <b>NULL</b> then
        ///             <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code> will contain a
        ///             comma-separated list of all the available names.
        ///         </param>
        /// <param name="pchValueBuffer">char *: 
        ///             Returns the value associated with
        ///             <code class="bb_code bb_code_inline nohighlight">pchPropertyName</code>.
        ///         </param>
        /// <param name="punValueBufferSizeOut">uint32
        ///             *: 
        ///             This should be set to the size of
        ///             <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code>, and returns the
        ///             number of bytes required to hold the value.
        ///         </param>
        public static bool GetResultItemProperty(SteamInventoryResult resultHandle, uint unItemIndex, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut) => Instance.GetResultItemProperty(resultHandle, unItemIndex, pchPropertyName, pchValueBuffer, punValueBufferSizeOut);
        /// <summary>
        /// <code>uint32 GetResultTimestamp( SteamInventoryResult_t resultHandle );</code>
        /// 
        /// <br />
        /// Gets the server time at which the result was generated.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The timestamp is provided as Unix epoch time (Time since Jan 1st, 1970)<br />
        /// <br />
        /// You can compare this value against
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetServerRealTime" class="bb_apilink">ISteamUtils::GetServerRealTime</a>
        /// to determine the age of the result.
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The inventory result handle to get the timestamp for.</param>
        public static uint GetResultTimestamp(SteamInventoryResult resultHandle) => Instance.GetResultTimestamp(resultHandle);
        /// <summary>
        /// <code>
        ///     bool CheckResultSteamID( SteamInventoryResult_t resultHandle, CSteamID steamIDExpected );
        /// </code>
        /// 
        /// <br />
        /// Checks whether an inventory result handle belongs to the specified Steam ID.<br />
        /// <br />
        /// This is important when using
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DeserializeResult" class="bb_apilink">ISteamInventory::DeserializeResult</a>, to verify that a remote player is not pretending to have a different user's inventory.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the result belongs to the target steam ID; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The inventory result handle to check the Steam ID on.</param>
        /// <param name="steamIDExpected">CSteamID: The Steam ID to verify.</param>
        public static bool CheckResultSteamID(SteamInventoryResult resultHandle, SteamId steamIDExpected) => Instance.CheckResultSteamID(resultHandle, steamIDExpected);
        /// <summary>
        /// <code>void DestroyResult( SteamInventoryResult_t resultHandle );</code>
        /// 
        /// <br />
        /// Destroys a result handle and frees all associated memory.
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The inventory result handle to destroy.</param>
        public static void DestroyResult(SteamInventoryResult resultHandle) => Instance.DestroyResult(resultHandle);
        /// <summary>
        /// <code>bool GetAllItems( SteamInventoryResult_t *pResultHandle );</code>
        /// 
        /// <br />
        /// Start retrieving all items in the current users inventory.<br />
        /// <br />
        /// <b>NOTE:</b> Calls to this function are subject to rate limits and may return cached
        /// results if called too frequently. It is suggested that you call this function only when you are
        /// about to display the user's full inventory, or if you expect that the inventory may have changed.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void SpaceWarItem::LoadInventory( IGameEngine *pGameEngine ) { SteamInventory()-&gt;GetAllItems(
        ///     &amp;s_RequestResult ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        public static bool GetAllItems(SteamInventoryResult* pResultHandle) => Instance.GetAllItems(pResultHandle);
        /// <summary>
        /// <code>
        ///     bool GetItemsByID( SteamInventoryResult_t *pResultHandle, const SteamItemInstanceID_t
        ///     *pInstanceIDs, uint32 unCountInstanceIDs );
        /// </code>
        /// 
        /// <br />
        /// Gets the state of a subset of the current user's inventory.<br />
        /// <br />
        /// The subset is specified by an array of item instance IDs.<br />
        /// <br />
        /// The results from this call can be serialized using
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SerializeResult" class="bb_apilink">ISteamInventory::SerializeResult</a>
        /// and passed to other players to "prove" that the current user owns specific items, without exposing
        /// the user's entire inventory. For example, you could call this with the IDs of the user's currently
        /// equipped items and serialize this to a buffer, and then transmit this buffer to other players upon
        /// joining a game.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="pInstanceIDs">const
        ///             SteamItemInstanceID_t
        ///             *: A list of the item instance ids to update the state of.</param>
        /// <param name="unCountInstanceIDs">uint32: 
        ///             The number of items in
        ///             <code class="bb_code bb_code_inline nohighlight">pInstanceIDs</code>.
        ///         </param>
        public static bool GetItemsByID(SteamInventoryResult* pResultHandle, SteamItemInstanceID* pInstanceIDs, uint unCountInstanceIDs) => Instance.GetItemsByID(pResultHandle, pInstanceIDs, unCountInstanceIDs);
        /// <summary>
        /// <code>
        ///     bool SerializeResult( SteamInventoryResult_t resultHandle, void *pOutBuffer, uint32
        ///     *punOutBufferSize );
        /// </code>
        /// 
        /// <br />
        /// Serialized result sets contain a short signature which can't be forged or replayed across different
        /// game sessions.<br />
        /// <br />
        /// A result set can be serialized on the local client, transmitted to other players via your game
        /// networking, and deserialized by the remote players. This is a secure way of preventing hackers from
        /// lying about posessing rare/high-value items. Serializes a result set with signature bytes to an
        /// output buffer. The size of a serialized result depends on the number items which are being
        /// serialized. When securely transmitting items to other players, it is recommended to use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemsByID" class="bb_apilink">ISteamInventory::GetItemsByID</a>
        /// first to create a minimal result set.<br />
        /// <br />
        /// Results have a built-in timestamp which will be considered "expired" after an hour has elapsed. See
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DeserializeResult" class="bb_apilink">ISteamInventory::DeserializeResult</a>
        /// for expiration handling.<br />
        /// <br />
        /// If this is set <code class="bb_code bb_code_inline nohighlight">pOutBuffer</code> to
        /// <b>NULL</b> then
        /// <code class="bb_code bb_code_inline nohighlight">punOutBufferSize</code> will be set to the buffer
        /// size required. So you can make the buffer and then call this again to fill it with the data.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicating that
        /// <code class="bb_code bb_code_inline nohighlight">punOutBufferSize</code> has been successfully
        /// filled with the size of the buffer, and if
        /// <code class="bb_code bb_code_inline nohighlight">pOutBuffer</code> points to a buffer of sufficient
        /// size then it is filled out as well.<br />
        /// <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         The function was not called by a regular user. This call is not supported on GameServers.<br />
        ///     </li>
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">resultHandle</code> is invalid or the
        ///         inventory result handle is not ready.<br />
        ///     </li>
        ///     <li>
        ///         The value passed into
        ///         <code class="bb_code bb_code_inline nohighlight">punOutBufferSize</code> was smaller then
        ///         expected and <code class="bb_code bb_code_inline nohighlight">pOutBuffer</code> was not
        ///         <strong>NULL</strong>.
        ///     </li>
        /// </ul>
        /// </summary>
        /// <param name="resultHandle">SteamInventoryResult_t: The inventory result handle to serialize.</param>
        /// <param name="pOutBuffer">void *: The buffer that the serialized result will be copied into.</param>
        /// <param name="punOutBufferSize">uint32
        ///             *: 
        ///             This should be set to the size of
        ///             <code class="bb_code bb_code_inline nohighlight">pOutBuffer</code>. If
        ///             <code class="bb_code bb_code_inline nohighlight">pOutBuffer</code> is
        ///             <b>NULL</b> then this will return the size required to hold the buffer.
        ///         </param>
        public static bool SerializeResult(SteamInventoryResult resultHandle, void* pOutBuffer, uint* punOutBufferSize) => Instance.SerializeResult(resultHandle, pOutBuffer, punOutBufferSize);
        /// <summary>
        /// <code>
        ///     bool DeserializeResult( SteamInventoryResult_t *pOutResultHandle, const void *pBuffer, uint32
        ///     unBufferSize, bool bRESERVED_MUST_BE_FALSE = false );
        /// </code>
        /// 
        /// <br />
        /// Deserializes a result set and verifies the signature bytes.<br />
        /// <br />
        /// This call has a potential soft-failure mode where the handle status is set to
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultExpired" class="bb_apilink">k_EResultExpired</a>.
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetResultItems" class="bb_apilink">ISteamInventory::GetResultItems</a>
        /// will still succeed in this mode. The "expired" result could indicate that the data may be out of
        /// date - not just due to timed expiration (one hour), but also because one of the items in the result
        /// set may have been traded or consumed since the result set was generated. You could compare the
        /// timestamp from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetResultTimestamp" class="bb_apilink">ISteamInventory::GetResultTimestamp</a>
        /// to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetServerRealTime" class="bb_apilink">ISteamUtils::GetServerRealTime</a>
        /// to determine how old the data is. You could simply ignore the "expired" result code and continue as
        /// normal, or you could request the player with expired data to send an updated result set.<br />
        /// <br />
        /// You should call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#CheckResultSteamID" class="bb_apilink">ISteamInventory::CheckResultSteamID</a>
        /// on the result handle when it completes to verify that a remote player is not pretending to have a
        /// different user's inventory.<br />
        /// <br />
        /// NOTE: The <code class="bb_code bb_code_inline nohighlight">bRESERVED_MUST_BE_FALSE</code> parameter
        /// is reserved for future use and should never be set to true.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Always returns <b>true</b> and then delivers error codes via
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetResultStatus" class="bb_apilink">ISteamInventory::GetResultStatus</a>.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.
        /// </summary>
        /// <param name="pOutResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="pBuffer">const void *: The buffer to deserialize.</param>
        /// <param name="unBufferSize">uint32: The size of <code class="bb_code bb_code_inline nohighlight">pBuffer</code>.</param>
        /// <param name="bRESERVED_MUST_BE_FALSE">bool: This must be <b>false</b>!</param>
        public static bool DeserializeResult(SteamInventoryResult* pOutResultHandle, void* pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE) => Instance.DeserializeResult(pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
        /// <summary>
        /// <code>
        ///     bool GenerateItems( SteamInventoryResult_t *pResultHandle, const SteamItemDef_t *pArrayItemDefs,
        ///     const uint32 *punArrayQuantity, uint32 unArrayLength );
        /// </code>
        /// 
        /// <br />
        /// Grants specific items to the current user, for developers only.<br />
        /// <br />
        /// This API is only intended for prototyping - it is only usable by Steam accounts that belong to the
        /// publisher group for your game.<br />
        /// <br />
        /// You can pass in an array of items, identified by their
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamItemDef_t" class="bb_apilink">SteamItemDef_t</a>
        /// and optionally a second array of corresponding quantities for each item. The length of these arrays
        /// MUST match!<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::GrantTestItems() { SteamItemDef_t newItems[2]; uint32 quantities[2];
        ///     newItems[0] = 110; newItems[1] = 111; quantities[0] = 1; quantities[1] = 1;
        ///     SteamInventory()-&gt;GenerateItems( &amp;s_GenerateRequestResult, newItems, quantities, 2 ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="pArrayItemDefs">const
        ///             SteamItemDef_t
        ///             *: The list of items to grant the user.</param>
        /// <param name="punArrayQuantity">const
        ///             uint32
        ///             *: 
        ///             The quantity of each item in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayItemDefs</code> to grant. This is
        ///             optional, pass in <b>NULL</b> to specify 1 of each item.
        ///         </param>
        /// <param name="unArrayLength">uint32: 
        ///             The number of items in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayItemDefs</code>.
        ///         </param>
        public static bool GenerateItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength) => Instance.GenerateItems(pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
        /// <summary>
        /// <code>bool GrantPromoItems( SteamInventoryResult_t *pResultHandle );</code>
        /// 
        /// <br />
        /// Grant all potential one-time promotional items to the current user.<br />
        /// <br />
        /// This can be safely called from the client because the items it can grant can be locked down via
        /// policies in the itemdefs. One of the primary scenarios for this call is to grant an item to users
        /// who also own a specific other game. If you want to grant specific promotional items rather than all
        /// of them see:
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#AddPromoItem" class="bb_apilink">ISteamInventory::AddPromoItem</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#AddPromoItems" class="bb_apilink">ISteamInventory::AddPromoItems</a>.<br />
        /// <br />
        /// Any items that can be granted MUST have a "promo" attribute in their itemdef. That promo item list a
        /// set of APPIDs that the user must own to be granted this given item. This version will grant all
        /// items that have promo attributes specified for them in the configured item definitions. This allows
        /// adding additional promotional items without having to update the game client. For example the
        /// following will allow the item to be granted if the user owns either TF2 or SpaceWar.<br />
        /// <br />
        /// <code class="bb_code bb_code_inline nohighlight">promo: owns:440;owns:480</code><br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// On success, the inventory result will include items which were granted, if any. If no items were
        /// granted because the user isn't eligible for any promotions, this is still considered a success.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::GrantPromoItems() { SteamInventory()-&gt;GrantPromoItems(
        ///     &amp;s_GenerateRequestResult ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        public static bool GrantPromoItems(SteamInventoryResult* pResultHandle) => Instance.GrantPromoItems(pResultHandle);
        /// <summary>
        /// <code>
        ///     bool AddPromoItem( SteamInventoryResult_t *pResultHandle, SteamItemDef_t itemDef );
        /// </code>
        /// 
        /// <br />
        /// Grant a specific one-time promotional item to the current user.<br />
        /// <br />
        /// This can be safely called from the client because the items it can grant can be locked down via
        /// policies in the itemdefs. One of the primary scenarios for this call is to grant an item to users
        /// who also own a specific other game. This can be useful if your game has custom UI for showing a
        /// specific promo item to the user otherwise if you want to grant multiple promotional items then use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#AddPromoItems" class="bb_apilink">ISteamInventory::AddPromoItems</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GrantPromoItems" class="bb_apilink">ISteamInventory::GrantPromoItems</a>.<br />
        /// <br />
        /// Any items that can be granted MUST have a "promo" attribute in their itemdef. That promo item list a
        /// set of APPIDs that the user must own to be granted this given item. This version will grant all
        /// items that have promo attributes specified for them in the configured item definitions. This allows
        /// adding additional promotional items without having to update the game client. For example the
        /// following will allow the item to be granted if the user owns either TF2 or SpaceWar.<br />
        /// <br />
        /// <code class="bb_code bb_code_inline nohighlight">promo: owns:440;owns:480</code><br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// On success, the inventory result will include items which were granted, if any. If no items were
        /// granted because the user isn't eligible for any promotions, this is still considered a success.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::GrantPromoItems() { SteamInventory()-&gt;AddPromoItem(
        ///     &amp;s_GenerateRequestResult, 110 ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="itemDef">SteamItemDef_t: The ItemDef to grant the player.</param>
        public static bool AddPromoItem(SteamInventoryResult* pResultHandle, SteamItemDef itemDef) => Instance.AddPromoItem(pResultHandle, itemDef);
        /// <summary>
        /// <code>
        ///     bool AddPromoItems( SteamInventoryResult_t *pResultHandle, const SteamItemDef_t *pArrayItemDefs,
        ///     uint32 unArrayLength );
        /// </code>
        /// 
        /// <br />
        /// Grant a specific one-time promotional item to the current user.<br />
        /// <br />
        /// This can be safely called from the client because the items it can grant can be locked down via
        /// policies in the itemdefs. One of the primary scenarios for this call is to grant an item to users
        /// who also own a specific other game. If you want to grant a single promotional item then use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#AddPromoItem" class="bb_apilink">ISteamInventory::AddPromoItem</a>. If you want to grant all possible promo items then use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GrantPromoItems" class="bb_apilink">ISteamInventory::GrantPromoItems</a>.<br />
        /// <br />
        /// Any items that can be granted MUST have a "promo" attribute in their itemdef. That promo item list a
        /// set of APPIDs that the user must own to be granted this given item. This version will grant all
        /// items that have promo attributes specified for them in the configured item definitions. This allows
        /// adding additional promotional items without having to update the game client. For example the
        /// following will allow the item to be granted if the user owns either TF2 or SpaceWar.<br />
        /// <br />
        /// <code class="bb_code bb_code_inline nohighlight">promo: owns:440;owns:480</code><br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// On success, the inventory result will include items which were granted, if any. If no items were
        /// granted because the user isn't eligible for any promotions, this is still considered a success.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::GrantPromoItems() { SteamItemDef_t newItems[2]; newItems[0] = 110; newItems[1]
        ///     = 111; SteamInventory()-&gt;AddPromoItems( &amp;s_GenerateRequestResult, newItems, 2 ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="pArrayItemDefs">const
        ///             SteamItemDef_t
        ///             *: The list of items to grant the user.</param>
        /// <param name="unArrayLength">uint32: 
        ///             The number of items in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayItemDefs</code>.
        ///         </param>
        public static bool AddPromoItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint unArrayLength) => Instance.AddPromoItems(pResultHandle, pArrayItemDefs, unArrayLength);
        /// <summary>
        /// <code>
        ///     bool ConsumeItem( SteamInventoryResult_t *pResultHandle, SteamItemInstanceID_t itemConsume,
        ///     uint32 unQuantity );
        /// </code>
        /// 
        /// <br />
        /// Consumes items from a user's inventory. If the quantity of the given item goes to zero, it is
        /// permanently removed.<br />
        /// <br />
        /// Once an item is removed it cannot be recovered. This is not for the faint of heart - if your game
        /// implements item removal at all, a high-friction UI confirmation process is highly recommended.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#ExchangeItems" class="bb_apilink">ISteamInventory::ExchangeItems</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#TransferItemQuantity" class="bb_apilink">ISteamInventory::TransferItemQuantity</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::DrinkOnePotion( SteamItemInstanceID_t itemID ) {
        ///     SteamInventory()-&gt;ConsumeItem( &amp;s_ConsumeRequestResult, itemID, 1 ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="itemConsume">SteamItemInstanceID_t: The item instance id to consume.</param>
        /// <param name="unQuantity">uint32: The number of items in that stack to consume.</param>
        public static bool ConsumeItem(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemConsume, uint unQuantity) => Instance.ConsumeItem(pResultHandle, itemConsume, unQuantity);
        /// <summary>
        /// <code>
        ///     bool ExchangeItems( SteamInventoryResult_t *pResultHandle, const SteamItemDef_t *pArrayGenerate,
        ///     const uint32 *punArrayGenerateQuantity, uint32 unArrayGenerateLength, const
        ///     SteamItemInstanceID_t *pArrayDestroy, const uint32 *punArrayDestroyQuantity, uint32
        ///     unArrayDestroyLength );
        /// </code>
        /// 
        /// <br />
        /// Grant one item in exchange for a set of other items.<br />
        /// <br />
        /// This can be used to implement crafting recipes or transmutations, or items which unpack themselves
        /// into other items (e.g., a chest).<br />
        /// <br />
        /// The caller of this API passes in the requested item and an array of existing items and quantities to
        /// exchange for it. The API currently takes an array of items to generate but at this time the size of
        /// that array must be 1 and the quantity of the new item must be 1.<br />
        /// <br />
        /// Any items that can be granted MUST have an exchange attribute in their itemdef. The exchange
        /// attribute specifies a set of recipes that are valid exchanges for this item. Exchange recipes are
        /// evaluated atomically by the Inventory Service; if the supplied components do not match the recipe,
        /// or do not contain sufficient quantity, the exchange will fail.<br />
        /// <br />
        /// For example:<br />
        /// <code>exchange: 101x1,102x1;103x5;104x3,105x3</code>
        /// <br />
        /// Will allow the item to be exchanged for either one #101 and one #102, five #103s or three #104s and
        /// three #105s. See the
        /// <a href="https://partner.steamgames.com/doc/features/inventory/schema" class="bb_doclink">Steam Inventory Schema</a>
        /// documentation for more details.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> indicating success, and returns
        /// <b>false</b> when called from SteamGameServer or when
        /// <code class="bb_code bb_code_inline nohighlight">unArrayGenerateLength</code> or
        /// <code class="bb_code bb_code_inline nohighlight">punArrayGenerateQuantity</code> is not set to
        /// <b>1</b>.<br />
        /// <br />
        /// Exchanges that do not match a recipe, or do not provide the required amounts, will fail.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#ConsumeItem" class="bb_apilink">ISteamInventory::ConsumeItem</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#TransferItemQuantity" class="bb_apilink">ISteamInventory::TransferItemQuantity</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     // Find an item in the user's inventory with the given itemdef SteamItemInstanceID_t
        ///     CInventory::GetItemIdFromInventory( SteamItemDef_t itemDefId ); void CInventory::Exchange() {
        ///     SteamItemInstanceID_t inputItems[2]; uint32 inputQuantities[2]; inputItems[0] =
        ///     GetItemIdFromInventory( 103 ); inputQuantities[0] = 3; inputItems[1] = GetItemIdFromInventory(
        ///     104 ); inputQuantities[1] = 3; SteamItemDef_t outputItems[1]; outputItems[0] = 100; uint32
        ///     outputQuantity[1]; outputQuantity[0] = 1; SteamInventory()-&gt;ExchangeItems(
        ///     &amp;s_ExchangeRequestResult, outputItems, outputQuantity, 1, inputItems, inputQuantities, 2 );
        ///     }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="pArrayGenerate">const
        ///             SteamItemDef_t
        ///             *: The list of items that will be created by this call. Currently can only be 1 item!</param>
        /// <param name="punArrayGenerateQuantity">const
        ///             uint32
        ///             *: 
        ///             The quantity of each item in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayGenerate</code> to create.
        ///             Currently can only be 1 item and it must be set to <b>1</b>!
        ///         </param>
        /// <param name="unArrayGenerateLength">uint32: 
        ///             The number of items in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayGenerate</code> and
        ///             <code class="bb_code bb_code_inline nohighlight">punArrayGenerateQuantity</code>.
        ///             Currently must be <b>1</b>!
        ///         </param>
        /// <param name="pArrayDestroy">const
        ///             SteamItemInstanceID_t
        ///             *: The list of items that will be destroyed by this call.</param>
        /// <param name="punArrayDestroyQuantity">const
        ///             uint32
        ///             *: 
        ///             The quantity of each item in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayDestroy</code> to destroy.
        ///         </param>
        /// <param name="unArrayDestroyLength">uint32: 
        ///             The number of items in
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayDestroy</code> and
        ///             <code class="bb_code bb_code_inline nohighlight">punArrayDestroyQuantity</code>.
        ///         </param>
        public static bool ExchangeItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayGenerate, uint* punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID* pArrayDestroy, uint* punArrayDestroyQuantity, uint unArrayDestroyLength) => Instance.ExchangeItems(pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
        /// <summary>
        /// <code>
        ///     bool TransferItemQuantity( SteamInventoryResult_t *pResultHandle, SteamItemInstanceID_t
        ///     itemIdSource, uint32 unQuantity, SteamItemInstanceID_t itemIdDest );
        /// </code>
        /// 
        /// <br />
        /// Transfer items between stacks within a user's inventory.<br />
        /// <br />
        /// This can be used to stack, split, and moving items. The source and destination items must have the
        /// same itemdef id. To move items onto a destination stack specify the source, the quantity to move,
        /// and the destination item id. To split an existing stack, pass
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#k_SteamItemInstanceIDInvalid" class="bb_apilink">k_SteamItemInstanceIDInvalid</a>
        /// into <code class="bb_code bb_code_inline nohighlight">itemIdDest</code>. A new item stack will be
        /// generated with the requested quantity.<br />
        /// <br />
        /// <b>NOTE:</b> Tradability/marketability restrictions are copied along with transferred
        /// items. The destination stack receives the latest tradability/marketability date of any item in its
        /// composition.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#ConsumeItem" class="bb_apilink">ISteamInventory::ConsumeItem</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#ExchangeItems" class="bb_apilink">ISteamInventory::ExchangeItems</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::CombineItems() { SteamInventoryResult_t transferResult; // split 2 items from
        ///     an existing stack SteamItemInstanceID_t bigStack = GetItemIdFromInventory( ... );
        ///     SteamInventory()-&gt;TransferItemQuantity( &amp;transferResult, bigStack, 1,
        ///     k_SteamItemInstanceIDInvalid ); // move 2 from stack A to stack B SteamItemInstanceID_t
        ///     originStack = GetItemIdFromInventory( ... ); SteamItemInstanceID_t destStack =
        ///     GetItemIdFromInventory( ... ); SteamInventory()-&gt;TransferItemQuantity( &amp;transferResult,
        ///     originStack, 2, destStack ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="itemIdSource">SteamItemInstanceID_t: The source item to transfer.</param>
        /// <param name="unQuantity">uint32: 
        ///             The quantity of the item that will be transfered from
        ///             <code class="bb_code bb_code_inline nohighlight">itemIdSource</code> to
        ///             <code class="bb_code bb_code_inline nohighlight">itemIdDest</code>.
        ///         </param>
        /// <param name="itemIdDest">SteamItemInstanceID_t: 
        ///             The destination item. You can pass
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#k_SteamItemInstanceIDInvalid" class="bb_apilink">k_SteamItemInstanceIDInvalid</a>
        ///             to split the source stack into a new item stack with the requested quantity.
        ///         </param>
        public static bool TransferItemQuantity(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemIdSource, uint unQuantity, SteamItemInstanceID itemIdDest) => Instance.TransferItemQuantity(pResultHandle, itemIdSource, unQuantity, itemIdDest);
        /// <summary>
        /// <code>void SendItemDropHeartbeat();</code>
        /// Deprecated.
        /// </summary>
        /// 
        public static void SendItemDropHeartbeat() => Instance.SendItemDropHeartbeat();
        /// <summary>
        /// <code>
        ///     bool TriggerItemDrop( SteamInventoryResult_t *pResultHandle, SteamItemDef_t dropListDefinition
        ///     );
        /// </code>
        /// 
        /// <br />
        /// Trigger an item drop if the user has played a long enough period of time.<br />
        /// <br />
        /// This period can be customized in two places:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         At the application level within Inventory Service: Playtime Item Grants. This will
        ///         automatically apply to all "playtimegenerator" items that do not specify any overrides.<br />
        ///     </li>
        ///     <li>
        ///         In an individual "playtimegenerator" item definition. The settings would take precedence
        ///         over any application-level settings.
        ///     </li>
        /// </ul>
        /// <br />
        /// Only item definitions which are marked as "playtime item generators" can be spawned.<br />
        /// <br />
        /// Typically this function should be called at the end of a game or level or match or any point of
        /// significance in the game in which an item drop could occur. The granularity of the playtime
        /// generator settings is in minutes, so calling it more frequently than minutes is not useful and will
        /// be rate limited in the Steam client. The Steam servers will perform playtime accounting to prevent
        /// too-frequent drops. The servers will also manage adding the item to the players inventory.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b> when called by a regular user, and always returns
        /// <b>false</b> when called from SteamGameServer.<br />
        /// <br />
        /// Returns a new result handle via
        /// <code class="bb_code bb_code_inline nohighlight">pResultHandle</code>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result when you are done with it.<br />
        /// <br />
        /// The inventory result returned by this function will be the new item granted if the player is
        /// eligible. If the user is not eligible then it will return an empty result ('[]').<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::FinishGame() { SteamInventory()-&gt;TriggerItemDrop(
        ///     &amp;s_PlaytimeRequestResult, 10 ); }
        /// </code>
        /// </summary>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        /// <param name="dropListDefinition">SteamItemDef_t: 
        ///             This must refer to an itemdefid of the type "playtimegenerator". See the
        ///             <a href="https://partner.steamgames.com/doc/features/inventory/schema" class="bb_doclink">inventory schema</a>
        ///             for more details.
        ///         </param>
        public static bool TriggerItemDrop(SteamInventoryResult* pResultHandle, SteamItemDef dropListDefinition) => Instance.TriggerItemDrop(pResultHandle, dropListDefinition);
        /// missing documentation
        public static bool TradeItems(SteamInventoryResult* pResultHandle, SteamId steamIDTradePartner, SteamItemInstanceID* pArrayGive, uint* pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID* pArrayGet, uint* pArrayGetQuantity, uint nArrayGetLength) => Instance.TradeItems(pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
        /// <summary>
        /// <code>bool LoadItemDefinitions();</code>
        /// Triggers an asynchronous load and refresh of item definitions.<br />
        /// <br />
        /// Item definitions are a mapping of "definition IDs" (integers between 1 and 999999999) to a set of
        /// string properties. Some of these properties are required to display items on the Steam community web
        /// site. Other properties can be defined by applications. There is no reason to call this function if
        /// your game hardcoded the numeric definition IDs (e.g. purple face mask = 20, blue weapon mod = 55)
        /// and does not allow for adding new item types without a client patch.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryDefinitionUpdate_t" class="bb_apilink">SteamInventoryDefinitionUpdate_t</a>
        /// callback.<br />
        /// This call will always return <b>true</b>.
        /// </summary>
        /// 
        public static bool LoadItemDefinitions() => Instance.LoadItemDefinitions();
        /// <summary>
        /// <code>
        ///     bool GetItemDefinitionIDs( SteamItemDef_t *pItemDefIDs, uint32 *punItemDefIDsArraySize );
        /// </code>
        /// 
        /// <br />
        /// Returns the set of all item definition IDs which are defined in the App Admin panel of the
        /// Steamworks website.<br />
        /// <br />
        /// These item definitions may not necessarily be contiguous integers.<br />
        /// <br />
        /// This should be called in response to a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryDefinitionUpdate_t" class="bb_apilink">SteamInventoryDefinitionUpdate_t</a>
        /// callback. There is no reason to call this function if your game hardcodes the numeric definition IDs
        /// (eg, purple face mask = 20, blue weapon mod = 55) and does not allow for adding new item types
        /// without a client patch.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This call returns <b>true</b> upon success. It only returns <b>false</b> if item
        /// definitions have not been loaded from the server, or no item defintions exist for the current
        /// application.<br />
        /// <br />
        /// If the call is successful then
        /// <code class="bb_code bb_code_inline nohighlight">punItemDefIDsArraySize</code> will contain the
        /// number of item definitions available.
        /// </summary>
        /// <param name="pItemDefIDs">SteamItemDef_t
        ///             *: Returns the item definitions by copying them into this array.</param>
        /// <param name="punItemDefIDsArraySize">uint32
        ///             *: 
        ///             This should be set to the length of
        ///             <code class="bb_code bb_code_inline nohighlight">pItemDefIDs</code>. If
        ///             <code class="bb_code bb_code_inline nohighlight">pItemDefIDs</code> is
        ///             <b>NULL</b> then this will return the number of elements the array needs to
        ///             hold.
        ///         </param>
        public static bool GetItemDefinitionIDs(SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize) => Instance.GetItemDefinitionIDs(pItemDefIDs, punItemDefIDsArraySize);
        /// <summary>
        /// <code>
        ///     bool GetItemDefinitionProperty( SteamItemDef_t iDefinition, const char *pchPropertyName, char
        ///     *pchValueBuffer, uint32 *punValueBufferSizeOut );
        /// </code>
        /// 
        /// <br />
        /// Gets a string property from the specified item definition.<br />
        /// Gets a property value for a specific item definition.<br />
        /// <br />
        /// Note that some properties (for example, "name") may be localized and will depend on the current
        /// Steam language settings (see
        /// <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetCurrentGameLanguage" class="bb_apilink">ISteamApps::GetCurrentGameLanguage</a>). Property names are always ASCII alphanumeric and underscores.<br />
        /// <br />
        /// Pass in <b>NULL</b> for
        /// <code class="bb_code bb_code_inline nohighlight">pchPropertyName</code> to get a comma-separated
        /// list of available property names. In this mode,
        /// <code class="bb_code bb_code_inline nohighlight">punValueBufferSizeOut</code> will contain the
        /// suggested buffer size. Otherwise it will be the number of bytes actually copied to
        /// <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This returns <b>true</b> upon success; otherwise, <b>false</b> indicating that
        /// the item definitions have not been loaded from the server, or no item definitions exist for the
        /// current application, or the property name was not found in the item definition.<br />
        /// <br />
        /// The associated value is returned via
        /// <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code>, and the total number of
        /// bytes required to hold the value is available from
        /// <code class="bb_code bb_code_inline nohighlight">punValueBufferSizeOut</code>. It's recommended to
        /// call this function twice, the first time with
        /// <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code> set to
        /// <b>NULL</b> and
        /// <code class="bb_code bb_code_inline nohighlight">punValueBufferSizeOut</code> set to zero to get the
        /// size required for the buffer for the subsequent call.<br />
        /// <br />
        /// The output looks something like this:<br />
        /// <code class="bb_code bb_code_inline nohighlight">pchPropertyName</code> set to
        /// <b>NULL</b>:<br />
        /// <code class="bb_code bb_code_inline nohighlight">appid,itemdefid,Timestamp</code> etc...<br />
        /// <code class="bb_code bb_code_inline nohighlight">pchPropertyName</code> set to
        /// <b>"name"</b>:<br />
        /// <code class="bb_code bb_code_inline nohighlight">SW_DECORATION_HAT</code><br />
        /// <br />
        /// <b>NOTE:</b> Call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#LoadItemDefinitions" class="bb_apilink">ISteamInventory::LoadItemDefinitions</a>
        /// first, to ensure that items are ready to be used before calling GetItemDefinitionProperty.
        /// </summary>
        /// <param name="iDefinition">SteamItemDef_t: The item definition to get the properties for.</param>
        /// <param name="pchPropertyName">const char *: 
        ///             The property name to get the value for. If you pass in <b>NULL</b> then
        ///             <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code> will contain a
        ///             comma-separated list of all the available names.
        ///         </param>
        /// <param name="pchValueBuffer">char *: 
        ///             Returns the value associated with
        ///             <code class="bb_code bb_code_inline nohighlight">pchPropertyName</code>.
        ///         </param>
        /// <param name="punValueBufferSizeOut">uint32
        ///             *: 
        ///             This should be set to the size of
        ///             <code class="bb_code bb_code_inline nohighlight">pchValueBuffer</code>, and returns the
        ///             number of bytes required to hold the value.
        ///         </param>
        public static bool GetItemDefinitionProperty(SteamItemDef iDefinition, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut) => Instance.GetItemDefinitionProperty(iDefinition, pchPropertyName, pchValueBuffer, punValueBufferSizeOut);
        /// <summary>
        /// <code>
        ///     SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs( CSteamID steamID );
        /// </code>
        /// 
        /// <br />
        /// Request the list of "eligible" promo items that can be manually granted to the given user.<br />
        /// <br />
        /// These are promo items of type "manual" that won't be granted automatically. An example usage of this
        /// is an item that becomes available every week.<br />
        /// <br />
        /// After calling this function you need to call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetEligiblePromoItemDefinitionIDs" class="bb_apilink">ISteamInventory::GetEligiblePromoItemDefinitionIDs</a>
        /// to get the actual item definition ids.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryEligiblePromoItemDefIDs_t" class="bb_apilink">SteamInventoryEligiblePromoItemDefIDs_t</a>
        /// call result.<br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a>
        /// if the <code class="bb_code bb_code_inline nohighlight">steamID</code> is not a valid individual
        /// account.
        /// </summary>
        /// <param name="steamID">CSteamID: The Steam ID of the user to request the eligible promo items for.</param>
        public static SteamAPICall RequestEligiblePromoItemDefinitionsIDs(SteamId steamID) => Instance.RequestEligiblePromoItemDefinitionsIDs(steamID);
        /// <summary>
        /// <code>
        ///     bool GetEligiblePromoItemDefinitionIDs( CSteamID steamID, SteamItemDef_t *pItemDefIDs, uint32
        ///     *punItemDefIDsArraySize );
        /// </code>
        /// 
        /// <br />
        /// Get the list of item definition ids that a user can be granted.<br />
        /// <br />
        /// You should call this while handling a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryEligiblePromoItemDefIDs_t" class="bb_apilink">SteamInventoryEligiblePromoItemDefIDs_t</a>
        /// call result to pull out the item definition ids.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#AddPromoItem" class="bb_apilink">ISteamInventory::AddPromoItem</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#AddPromoItems" class="bb_apilink">ISteamInventory::AddPromoItems</a>
        /// </summary>
        /// <param name="steamID">CSteamID: 
        ///             The Steam ID of the user who these items are for. This should be the same as
        ///             <code class="bb_code bb_code_inline nohighlight">SteamInventoryEligiblePromoItemDefIDs_t.m_steamID</code>.
        ///         </param>
        /// <param name="pItemDefIDs">SteamItemDef_t
        ///             *: Returns the item definition ids by copying them into this array.</param>
        /// <param name="punItemDefIDsArraySize">uint32
        ///             *: 
        ///             This should be the length of
        ///             <code class="bb_code bb_code_inline nohighlight">pItemDefIDs</code> and the same as
        ///             <code class="bb_code bb_code_inline nohighlight">SteamInventoryEligiblePromoItemDefIDs_t.m_numEligiblePromoItemDefs</code>.
        ///         </param>
        public static bool GetEligiblePromoItemDefinitionIDs(SteamId steamID, SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize) => Instance.GetEligiblePromoItemDefinitionIDs(steamID, pItemDefIDs, punItemDefIDsArraySize);
        /// <summary>
        /// <code>
        ///     SteamAPICall_t StartPurchase( const SteamItemDef_t *pArrayItemDefs, const uint32
        ///     *punArrayQuantity, uint32 unArrayLength );
        /// </code>
        /// 
        /// <br />
        /// Starts the purchase process for the user, given a "shopping cart" of item definitions that the user
        /// would like to buy. The user will be prompted in the Steam Overlay to complete the purchase in their
        /// local currency, funding their Steam Wallet if necessary, etc.<br />
        /// <br />
        /// If the purchase process was started successfully, then
        /// <code class="bb_code bb_code_inline nohighlight">m_ulOrderID</code> and
        /// <code class="bb_code bb_code_inline nohighlight">m_ulTransID</code><br />
        /// will be valid in the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryStartPurchaseResult_t" class="bb_apilink">SteamInventoryStartPurchaseResult_t</a>
        /// call result.<br />
        /// <br />
        /// If the user authorizes the transaction and completes the purchase, then the callback
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryResultReady_t" class="bb_apilink">SteamInventoryResultReady_t</a>
        /// will be triggered and you can then retrieve what new items the user has acquired.
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the inventory result for when you are done with it.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryStartPurchaseResult_t" class="bb_apilink">SteamInventoryStartPurchaseResult_t</a>
        /// call result.<br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a>
        /// if the input was invalid.
        /// <div class="bb_callout">
        ///     <div>
        ///         <strong>Testing while in Development:</strong> When testing StartPurchase before your app is
        ///         released, all transactions made by members of the development / publishing team will be made
        ///         through the Sandbox micro-transaction API internally. This means you will not be charged for
        ///         the purchases made before the app is released if you are part of the Steamworks publisher.
        ///     </div>
        /// </div>
        /// </summary>
        /// <param name="pArrayItemDefs">SteamItemDef_t
        ///             *: The array of item definition ids that the user wants to purchase.</param>
        /// <param name="punArrayQuantity">uint32
        ///             *: The array of quantities of each item definition that the user wants to purchase.</param>
        /// <param name="unArrayLength">uint32: 
        ///             This should be the length of
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayItemDefs</code> and
        ///             <code class="bb_code bb_code_inline nohighlight">punArrayQuantity</code> arrays.
        ///         </param>
        public static SteamAPICall StartPurchase(SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength) => Instance.StartPurchase(pArrayItemDefs, punArrayQuantity, unArrayLength);
        /// <summary>
        /// <code>SteamAPICall_t RequestPrices();</code>
        /// <br />
        /// Request prices for all item definitions that can be purchased in the user's local currency. A
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryRequestPricesResult_t" class="bb_apilink">SteamInventoryRequestPricesResult_t</a>
        /// call result will be returned with the user's local currency code. After that, you can call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetNumItemsWithPrices" class="bb_apilink">ISteamInventory::GetNumItemsWithPrices</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemsWithPrices" class="bb_apilink">ISteamInventory::GetItemsWithPrices</a>
        /// to get prices for all the known item definitions, or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemPrice" class="bb_apilink">ISteamInventory::GetItemPrice</a>
        /// for a specific item definition.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryRequestPricesResult_t" class="bb_apilink">SteamInventoryRequestPricesResult_t</a>
        /// call result.<br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a>
        /// if there was an internal problem.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetNumItemsWithPrices" class="bb_apilink">ISteamInventory::GetNumItemsWithPrices</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemsWithPrices" class="bb_apilink">ISteamInventory::GetItemsWithPrices</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemPrice" class="bb_apilink">ISteamInventory::GetItemPrice</a>
        /// </summary>
        /// 
        public static SteamAPICall RequestPrices() => Instance.RequestPrices();
        /// <summary>
        /// <code>uint32 GetNumItemsWithPrices();</code>
        /// After a successful call to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a>, this will return the number of item definitions with valid pricing.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemsWithPrices" class="bb_apilink">ISteamInventory::GetItemsWithPrices</a>
        /// </summary>
        /// 
        public static uint GetNumItemsWithPrices() => Instance.GetNumItemsWithPrices();
        /// <summary>
        /// <code>
        ///     bool GetItemsWithPrices( SteamItemDef_t *pArrayItemDefs, uint64 *pPrices, uint32 unArrayLength
        ///     );
        /// </code>
        /// 
        /// <br />
        /// After a successful call to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a>, you can call this method to get all the pricing for applicable item definitions. Use the result
        /// of
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetNumItemsWithPrices" class="bb_apilink">ISteamInventory::GetNumItemsWithPrices</a>
        /// as the the size of the arrays that you pass in.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicating that
        /// <code class="bb_code bb_code_inline nohighlight">pArrayItemDefs</code> and
        /// <code class="bb_code bb_code_inline nohighlight">pPrices</code> have been successfully filled with
        /// the item definition ids and prices of items that are for sale.<br />
        /// <b>false</b> if the parameters are invalid<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetItemPrice" class="bb_apilink">ISteamInventory::GetItemPrice</a>
        /// </summary>
        /// <param name="pArrayItemDefs">SteamItemDef_t
        ///             *: The array of item definition ids to populate</param>
        /// <param name="pPrices">uint64*: 
        ///             The array of prices for each corresponding item definition id in pArrayItemDefs. Prices
        ///             are rendered in the user's
        ///             <a href="https://partner.steamgames.com/doc/store/pricing/currencies" class="bb_doclink">local currency</a>.
        ///         </param>
        /// <param name="unArrayLength">uint32: 
        ///             This should be the length of
        ///             <code class="bb_code bb_code_inline nohighlight">pArrayItemDefs</code> and
        ///             <code class="bb_code bb_code_inline nohighlight">pPrices</code> arrays, which are
        ///             derived from the result of calling
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetNumItemsWithPrices" class="bb_apilink">ISteamInventory::GetNumItemsWithPrices</a>
        ///             .
        ///         </param>
        public static bool GetItemsWithPrices(SteamItemDef* pArrayItemDefs, ulong* pCurrentPrices, ulong* pBasePrices, uint unArrayLength) => Instance.GetItemsWithPrices(pArrayItemDefs, pCurrentPrices, pBasePrices, unArrayLength);
        /// <summary>
        /// <code>bool GetItemPrice( SteamItemDef_t iDefinition, uint64 *pPrice );</code>
        /// 
        /// <br />
        /// After a successful call to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a>, you can call this method to get the pricing for a specific item definition.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicating that
        /// <code class="bb_code bb_code_inline nohighlight">pPrice</code> has been successfully filled with the
        /// price for the given item definition id.<br />
        /// <b>false</b> if the parameters are invalid or if there is no price for the given item
        /// definition id.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a>
        /// </summary>
        /// <param name="iDefinition">SteamItemDef_t: The item definition id to retrieve the price for</param>
        /// <param name="pPrice">uint64*: 
        ///             The price pointer to populate. Prices are rendered in the user's
        ///             <a href="https://partner.steamgames.com/doc/store/pricing/currencies" class="bb_doclink">local currency</a>.
        ///         </param>
        public static bool GetItemPrice(SteamItemDef iDefinition, ulong* pCurrentPrice, ulong* pBasePrice) => Instance.GetItemPrice(iDefinition, pCurrentPrice, pBasePrice);
        /// <summary>
        /// <code>SteamInventoryUpdateHandle_t StartUpdateProperties();</code>
        /// <br />
        /// Starts a transaction request to update
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic properties</a>
        /// on items for the current user. This call is rate-limited by user, so property modifications should
        /// be batched as much as possible (e.g. at the end of a map or game session). After calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SetProperty" class="bb_apilink">ISteamInventory::SetProperty</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>
        /// for all the items that you want to modify, you will need to call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// to send the request to the Steam servers. A
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryResultReady_t" class="bb_apilink">SteamInventoryResultReady_t</a>
        /// callback will be fired with the results of the operation.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void CInventory::FinishLevel() { SteamInventoryUpdateHandle_t updateHandle =
        ///     SteamInventory()-&gt;StartUpdateProperties(); for ( SteamItemInstanceID_t itemid : m_vecItemIDs
        ///     ) { SteamInventory()-&gt;SetProperty( updateHandle, itemid, "string_value", "blah" );
        ///     SteamInventory()-&gt;SetProperty( updateHandle, itemid, "bool_value", true );
        ///     SteamInventory()-&gt;SetProperty( updateHandle, itemid, "int64_value", (int64)55 );
        ///     SteamInventory()-&gt;SetProperty( updateHandle, itemid, "float_value", 123.456f ); }
        ///     SteamInventoryResult_t resultHandle; SteamInventory()-&gt;SubmitUpdateProperties( updateHandle,
        ///     &amp;resultHandle ); }
        /// </code>
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result for
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// when you are done with it.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryUpdateHandle_t" class="bb_apilink">SteamInventoryUpdateHandle_t</a><br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SetProperty" class="bb_apilink">ISteamInventory::SetProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// </summary>
        /// 
        public static SteamInventoryUpdateHandle StartUpdateProperties() => Instance.StartUpdateProperties();
        /// <summary>
        /// <code>
        ///     bool RemoveProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const
        ///     char *pchPropertyName );
        /// </code>
        /// 
        /// <br />
        /// Removes a
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic property</a>
        /// for the given item.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SetProperty" class="bb_apilink">ISteamInventory::SetProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// </summary>
        /// <param name="handle">SteamInventoryUpdateHandle_t: 
        ///             The update handle corresponding to the transaction request, returned from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.
        ///         </param>
        /// <param name="nItemID">SteamItemInstanceID_t: ID of the item being modified.</param>
        /// <param name="pchPropertyName">const char*: The dynamic property being removed.</param>
        public static bool RemoveProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName) => Instance.RemoveProperty(handle, nItemID, pchPropertyName);
        /// <summary>
        /// <code>
        ///     bool SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, const char *pchPropertyValue ); bool SetProperty( SteamInventoryUpdateHandle_t
        ///     handle, SteamItemInstanceID_t nItemID, const char *pchPropertyName, bool bValue ); bool
        ///     SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, int64 nValue ); bool SetProperty( SteamInventoryUpdateHandle_t handle,
        ///     SteamItemInstanceID_t nItemID, const char *pchPropertyName, float flValue );
        /// </code>
        /// 
        /// <br />
        /// Sets a
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic property</a>
        /// for the given item. Supported value types are strings, boolean, 64 bit integers, and 32 bit
        /// floats.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// </summary>
        /// <param name="handle">SteamInventoryUpdateHandle_t: 
        ///             The update handle corresponding to the transaction request, returned from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.
        ///         </param>
        /// <param name="nItemID">SteamItemInstanceID_t: ID of the item being modified.</param>
        /// <param name="pchPropertyName">const char*: The dynamic property being added or updated.</param>
        /// <param name="pchPropertyValue">const char*: The string value being set.</param>
        /// <param name="bValue">bool: The boolean value being set.</param>
        /// <param name="nValue">int64: The 64 bit integer value being set.</param>
        /// <param name="flValue">float: The floating point number value being set.</param>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, UTF8StringPtr pchPropertyValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, pchPropertyValue);
        /// <summary>
        /// <code>
        ///     bool SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, const char *pchPropertyValue ); bool SetProperty( SteamInventoryUpdateHandle_t
        ///     handle, SteamItemInstanceID_t nItemID, const char *pchPropertyName, bool bValue ); bool
        ///     SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, int64 nValue ); bool SetProperty( SteamInventoryUpdateHandle_t handle,
        ///     SteamItemInstanceID_t nItemID, const char *pchPropertyName, float flValue );
        /// </code>
        /// 
        /// <br />
        /// Sets a
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic property</a>
        /// for the given item. Supported value types are strings, boolean, 64 bit integers, and 32 bit
        /// floats.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// </summary>
        /// <param name="handle">SteamInventoryUpdateHandle_t: 
        ///             The update handle corresponding to the transaction request, returned from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.
        ///         </param>
        /// <param name="nItemID">SteamItemInstanceID_t: ID of the item being modified.</param>
        /// <param name="pchPropertyName">const char*: The dynamic property being added or updated.</param>
        /// <param name="pchPropertyValue">const char*: The string value being set.</param>
        /// <param name="bValue">bool: The boolean value being set.</param>
        /// <param name="nValue">int64: The 64 bit integer value being set.</param>
        /// <param name="flValue">float: The floating point number value being set.</param>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, bool bValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, bValue);
        /// <summary>
        /// <code>
        ///     bool SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, const char *pchPropertyValue ); bool SetProperty( SteamInventoryUpdateHandle_t
        ///     handle, SteamItemInstanceID_t nItemID, const char *pchPropertyName, bool bValue ); bool
        ///     SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, int64 nValue ); bool SetProperty( SteamInventoryUpdateHandle_t handle,
        ///     SteamItemInstanceID_t nItemID, const char *pchPropertyName, float flValue );
        /// </code>
        /// 
        /// <br />
        /// Sets a
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic property</a>
        /// for the given item. Supported value types are strings, boolean, 64 bit integers, and 32 bit
        /// floats.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// </summary>
        /// <param name="handle">SteamInventoryUpdateHandle_t: 
        ///             The update handle corresponding to the transaction request, returned from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.
        ///         </param>
        /// <param name="nItemID">SteamItemInstanceID_t: ID of the item being modified.</param>
        /// <param name="pchPropertyName">const char*: The dynamic property being added or updated.</param>
        /// <param name="pchPropertyValue">const char*: The string value being set.</param>
        /// <param name="bValue">bool: The boolean value being set.</param>
        /// <param name="nValue">int64: The 64 bit integer value being set.</param>
        /// <param name="flValue">float: The floating point number value being set.</param>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, long nValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, nValue);
        /// <summary>
        /// <code>
        ///     bool SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, const char *pchPropertyValue ); bool SetProperty( SteamInventoryUpdateHandle_t
        ///     handle, SteamItemInstanceID_t nItemID, const char *pchPropertyName, bool bValue ); bool
        ///     SetProperty( SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, const char
        ///     *pchPropertyName, int64 nValue ); bool SetProperty( SteamInventoryUpdateHandle_t handle,
        ///     SteamItemInstanceID_t nItemID, const char *pchPropertyName, float flValue );
        /// </code>
        /// 
        /// <br />
        /// Sets a
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic property</a>
        /// for the given item. Supported value types are strings, boolean, 64 bit integers, and 32 bit
        /// floats.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SubmitUpdateProperties" class="bb_apilink">ISteamInventory::SubmitUpdateProperties</a>
        /// </summary>
        /// <param name="handle">SteamInventoryUpdateHandle_t: 
        ///             The update handle corresponding to the transaction request, returned from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.
        ///         </param>
        /// <param name="nItemID">SteamItemInstanceID_t: ID of the item being modified.</param>
        /// <param name="pchPropertyName">const char*: The dynamic property being added or updated.</param>
        /// <param name="pchPropertyValue">const char*: The string value being set.</param>
        /// <param name="bValue">bool: The boolean value being set.</param>
        /// <param name="nValue">int64: The 64 bit integer value being set.</param>
        /// <param name="flValue">float: The floating point number value being set.</param>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, float flValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, flValue);
        /// <summary>
        /// <code>
        ///     bool SubmitUpdateProperties( SteamInventoryUpdateHandle_t handle, SteamInventoryResult_t *
        ///     pResultHandle );
        /// </code>
        /// 
        /// <br />
        /// Submits the transaction request to modify
        /// <a href="https://partner.steamgames.com/doc/features/inventory/dynamicproperties" class="bb_doclink">dynamic properties</a>
        /// on items for the current user. See
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#DestroyResult" class="bb_apilink">ISteamInventory::DestroyResult</a>
        /// on the provided inventory result for when you are done with it.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SetProperty" class="bb_apilink">ISteamInventory::SetProperty</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RemoveProperty" class="bb_apilink">ISteamInventory::RemoveProperty</a>
        /// </summary>
        /// <param name="handle">SteamInventoryUpdateHandle_t: 
        ///             The update handle corresponding to the transaction request, returned from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>.
        ///         </param>
        /// <param name="pResultHandle">SteamInventoryResult_t
        ///             *: Returns a new inventory result handle.</param>
        public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle handle, SteamInventoryResult* pResultHandle) => Instance.SubmitUpdateProperties(handle, pResultHandle);
        /// missing documentation
        public static bool InspectItem(SteamInventoryResult* pResultHandle, UTF8StringPtr pchItemToken) => Instance.InspectItem(pResultHandle, pchItemToken);
    }
}