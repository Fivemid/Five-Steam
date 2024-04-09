using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamInventory</summary>
    public unsafe interface ISteamInventory
    {
        public Result GetResultStatus(SteamInventoryResult resultHandle);
        public bool GetResultItems(SteamInventoryResult resultHandle, SteamItemDetails* pOutItemsArray, uint* punOutItemsArraySize);
        public bool GetResultItemProperty(SteamInventoryResult resultHandle, uint unItemIndex, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut);
        public uint GetResultTimestamp(SteamInventoryResult resultHandle);
        public bool CheckResultSteamID(SteamInventoryResult resultHandle, SteamId steamIDExpected);
        public void DestroyResult(SteamInventoryResult resultHandle);
        public bool GetAllItems(SteamInventoryResult* pResultHandle);
        public bool GetItemsByID(SteamInventoryResult* pResultHandle, SteamItemInstanceID* pInstanceIDs, uint unCountInstanceIDs);
        public bool SerializeResult(SteamInventoryResult resultHandle, void* pOutBuffer, uint* punOutBufferSize);
        public bool DeserializeResult(SteamInventoryResult* pOutResultHandle, void* pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);
        public bool GenerateItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength);
        public bool GrantPromoItems(SteamInventoryResult* pResultHandle);
        public bool AddPromoItem(SteamInventoryResult* pResultHandle, SteamItemDef itemDef);
        public bool AddPromoItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint unArrayLength);
        public bool ConsumeItem(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemConsume, uint unQuantity);
        public bool ExchangeItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayGenerate, uint* punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID* pArrayDestroy, uint* punArrayDestroyQuantity, uint unArrayDestroyLength);
        public bool TransferItemQuantity(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemIdSource, uint unQuantity, SteamItemInstanceID itemIdDest);
        public void SendItemDropHeartbeat();
        public bool TriggerItemDrop(SteamInventoryResult* pResultHandle, SteamItemDef dropListDefinition);
        public bool TradeItems(SteamInventoryResult* pResultHandle, SteamId steamIDTradePartner, SteamItemInstanceID* pArrayGive, uint* pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID* pArrayGet, uint* pArrayGetQuantity, uint nArrayGetLength);
        public bool LoadItemDefinitions();
        public bool GetItemDefinitionIDs(SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize);
        public bool GetItemDefinitionProperty(SteamItemDef iDefinition, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut);
        public SteamAPICall RequestEligiblePromoItemDefinitionsIDs(SteamId steamID);
        public bool GetEligiblePromoItemDefinitionIDs(SteamId steamID, SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize);
        public SteamAPICall StartPurchase(SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength);
        public SteamAPICall RequestPrices();
        public uint GetNumItemsWithPrices();
        public bool GetItemsWithPrices(SteamItemDef* pArrayItemDefs, ulong* pCurrentPrices, ulong* pBasePrices, uint unArrayLength);
        public bool GetItemPrice(SteamItemDef iDefinition, ulong* pCurrentPrice, ulong* pBasePrice);
        public SteamInventoryUpdateHandle StartUpdateProperties();
        public bool RemoveProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName);
        public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, UTF8StringPtr pchPropertyValue);
        public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, bool bValue);
        public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, long nValue);
        public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, float flValue);
        public bool SubmitUpdateProperties(SteamInventoryUpdateHandle handle, SteamInventoryResult* pResultHandle);
        public bool InspectItem(SteamInventoryResult* pResultHandle, UTF8StringPtr pchItemToken);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetResultStatus", CallingConvention = Platform.CC)]
        internal static extern Result GetResultStatus(void* self, SteamInventoryResult resultHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetResultItems", CallingConvention = Platform.CC)]
        internal static extern bool GetResultItems(void* self, SteamInventoryResult resultHandle, SteamItemDetails* pOutItemsArray, uint* punOutItemsArraySize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetResultItemProperty", CallingConvention = Platform.CC)]
        internal static extern bool GetResultItemProperty(void* self, SteamInventoryResult resultHandle, uint unItemIndex, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetResultTimestamp", CallingConvention = Platform.CC)]
        internal static extern uint GetResultTimestamp(void* self, SteamInventoryResult resultHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_CheckResultSteamID", CallingConvention = Platform.CC)]
        internal static extern bool CheckResultSteamID(void* self, SteamInventoryResult resultHandle, SteamId steamIDExpected);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_DestroyResult", CallingConvention = Platform.CC)]
        internal static extern void DestroyResult(void* self, SteamInventoryResult resultHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetAllItems", CallingConvention = Platform.CC)]
        internal static extern bool GetAllItems(void* self, SteamInventoryResult* pResultHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetItemsByID", CallingConvention = Platform.CC)]
        internal static extern bool GetItemsByID(void* self, SteamInventoryResult* pResultHandle, SteamItemInstanceID* pInstanceIDs, uint unCountInstanceIDs);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SerializeResult", CallingConvention = Platform.CC)]
        internal static extern bool SerializeResult(void* self, SteamInventoryResult resultHandle, void* pOutBuffer, uint* punOutBufferSize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_DeserializeResult", CallingConvention = Platform.CC)]
        internal static extern bool DeserializeResult(void* self, SteamInventoryResult* pOutResultHandle, void* pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GenerateItems", CallingConvention = Platform.CC)]
        internal static extern bool GenerateItems(void* self, SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GrantPromoItems", CallingConvention = Platform.CC)]
        internal static extern bool GrantPromoItems(void* self, SteamInventoryResult* pResultHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItem", CallingConvention = Platform.CC)]
        internal static extern bool AddPromoItem(void* self, SteamInventoryResult* pResultHandle, SteamItemDef itemDef);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItems", CallingConvention = Platform.CC)]
        internal static extern bool AddPromoItems(void* self, SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint unArrayLength);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_ConsumeItem", CallingConvention = Platform.CC)]
        internal static extern bool ConsumeItem(void* self, SteamInventoryResult* pResultHandle, SteamItemInstanceID itemConsume, uint unQuantity);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_ExchangeItems", CallingConvention = Platform.CC)]
        internal static extern bool ExchangeItems(void* self, SteamInventoryResult* pResultHandle, SteamItemDef* pArrayGenerate, uint* punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID* pArrayDestroy, uint* punArrayDestroyQuantity, uint unArrayDestroyLength);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_TransferItemQuantity", CallingConvention = Platform.CC)]
        internal static extern bool TransferItemQuantity(void* self, SteamInventoryResult* pResultHandle, SteamItemInstanceID itemIdSource, uint unQuantity, SteamItemInstanceID itemIdDest);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SendItemDropHeartbeat", CallingConvention = Platform.CC)]
        internal static extern void SendItemDropHeartbeat(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_TriggerItemDrop", CallingConvention = Platform.CC)]
        internal static extern bool TriggerItemDrop(void* self, SteamInventoryResult* pResultHandle, SteamItemDef dropListDefinition);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_TradeItems", CallingConvention = Platform.CC)]
        internal static extern bool TradeItems(void* self, SteamInventoryResult* pResultHandle, SteamId steamIDTradePartner, SteamItemInstanceID* pArrayGive, uint* pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID* pArrayGet, uint* pArrayGetQuantity, uint nArrayGetLength);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_LoadItemDefinitions", CallingConvention = Platform.CC)]
        internal static extern bool LoadItemDefinitions(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionIDs", CallingConvention = Platform.CC)]
        internal static extern bool GetItemDefinitionIDs(void* self, SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionProperty", CallingConvention = Platform.CC)]
        internal static extern bool GetItemDefinitionProperty(void* self, SteamItemDef iDefinition, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestEligiblePromoItemDefinitionsIDs(void* self, SteamId steamID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs", CallingConvention = Platform.CC)]
        internal static extern bool GetEligiblePromoItemDefinitionIDs(void* self, SteamId steamID, SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_StartPurchase", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall StartPurchase(void* self, SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_RequestPrices", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestPrices(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetNumItemsWithPrices", CallingConvention = Platform.CC)]
        internal static extern uint GetNumItemsWithPrices(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetItemsWithPrices", CallingConvention = Platform.CC)]
        internal static extern bool GetItemsWithPrices(void* self, SteamItemDef* pArrayItemDefs, ulong* pCurrentPrices, ulong* pBasePrices, uint unArrayLength);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_GetItemPrice", CallingConvention = Platform.CC)]
        internal static extern bool GetItemPrice(void* self, SteamItemDef iDefinition, ulong* pCurrentPrice, ulong* pBasePrice);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_StartUpdateProperties", CallingConvention = Platform.CC)]
        internal static extern SteamInventoryUpdateHandle StartUpdateProperties(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_RemoveProperty", CallingConvention = Platform.CC)]
        internal static extern bool RemoveProperty(void* self, SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyString", CallingConvention = Platform.CC)]
        internal static extern bool SetProperty(void* self, SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, UTF8StringPtr pchPropertyValue);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyBool", CallingConvention = Platform.CC)]
        internal static extern bool SetProperty(void* self, SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, bool bValue);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyInt64", CallingConvention = Platform.CC)]
        internal static extern bool SetProperty(void* self, SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, long nValue);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyFloat", CallingConvention = Platform.CC)]
        internal static extern bool SetProperty(void* self, SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, float flValue);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_SubmitUpdateProperties", CallingConvention = Platform.CC)]
        internal static extern bool SubmitUpdateProperties(void* self, SteamInventoryUpdateHandle handle, SteamInventoryResult* pResultHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamInventory_InspectItem", CallingConvention = Platform.CC)]
        internal static extern bool InspectItem(void* self, SteamInventoryResult* pResultHandle, UTF8StringPtr pchItemToken);
        public struct Instance : ISteamInventory
        {
            public void* self;
            public Result GetResultStatus(SteamInventoryResult resultHandle) => ISteamInventory.GetResultStatus(self, resultHandle);
            public bool GetResultItems(SteamInventoryResult resultHandle, SteamItemDetails* pOutItemsArray, uint* punOutItemsArraySize) => ISteamInventory.GetResultItems(self, resultHandle, pOutItemsArray, punOutItemsArraySize);
            public bool GetResultItemProperty(SteamInventoryResult resultHandle, uint unItemIndex, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut) => ISteamInventory.GetResultItemProperty(self, resultHandle, unItemIndex, pchPropertyName, pchValueBuffer, punValueBufferSizeOut);
            public uint GetResultTimestamp(SteamInventoryResult resultHandle) => ISteamInventory.GetResultTimestamp(self, resultHandle);
            public bool CheckResultSteamID(SteamInventoryResult resultHandle, SteamId steamIDExpected) => ISteamInventory.CheckResultSteamID(self, resultHandle, steamIDExpected);
            public void DestroyResult(SteamInventoryResult resultHandle) => ISteamInventory.DestroyResult(self, resultHandle);
            public bool GetAllItems(SteamInventoryResult* pResultHandle) => ISteamInventory.GetAllItems(self, pResultHandle);
            public bool GetItemsByID(SteamInventoryResult* pResultHandle, SteamItemInstanceID* pInstanceIDs, uint unCountInstanceIDs) => ISteamInventory.GetItemsByID(self, pResultHandle, pInstanceIDs, unCountInstanceIDs);
            public bool SerializeResult(SteamInventoryResult resultHandle, void* pOutBuffer, uint* punOutBufferSize) => ISteamInventory.SerializeResult(self, resultHandle, pOutBuffer, punOutBufferSize);
            public bool DeserializeResult(SteamInventoryResult* pOutResultHandle, void* pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE) => ISteamInventory.DeserializeResult(self, pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
            public bool GenerateItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength) => ISteamInventory.GenerateItems(self, pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
            public bool GrantPromoItems(SteamInventoryResult* pResultHandle) => ISteamInventory.GrantPromoItems(self, pResultHandle);
            public bool AddPromoItem(SteamInventoryResult* pResultHandle, SteamItemDef itemDef) => ISteamInventory.AddPromoItem(self, pResultHandle, itemDef);
            public bool AddPromoItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint unArrayLength) => ISteamInventory.AddPromoItems(self, pResultHandle, pArrayItemDefs, unArrayLength);
            public bool ConsumeItem(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemConsume, uint unQuantity) => ISteamInventory.ConsumeItem(self, pResultHandle, itemConsume, unQuantity);
            public bool ExchangeItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayGenerate, uint* punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID* pArrayDestroy, uint* punArrayDestroyQuantity, uint unArrayDestroyLength) => ISteamInventory.ExchangeItems(self, pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
            public bool TransferItemQuantity(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemIdSource, uint unQuantity, SteamItemInstanceID itemIdDest) => ISteamInventory.TransferItemQuantity(self, pResultHandle, itemIdSource, unQuantity, itemIdDest);
            public void SendItemDropHeartbeat() => ISteamInventory.SendItemDropHeartbeat(self);
            public bool TriggerItemDrop(SteamInventoryResult* pResultHandle, SteamItemDef dropListDefinition) => ISteamInventory.TriggerItemDrop(self, pResultHandle, dropListDefinition);
            public bool TradeItems(SteamInventoryResult* pResultHandle, SteamId steamIDTradePartner, SteamItemInstanceID* pArrayGive, uint* pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID* pArrayGet, uint* pArrayGetQuantity, uint nArrayGetLength) => ISteamInventory.TradeItems(self, pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
            public bool LoadItemDefinitions() => ISteamInventory.LoadItemDefinitions(self);
            public bool GetItemDefinitionIDs(SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize) => ISteamInventory.GetItemDefinitionIDs(self, pItemDefIDs, punItemDefIDsArraySize);
            public bool GetItemDefinitionProperty(SteamItemDef iDefinition, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut) => ISteamInventory.GetItemDefinitionProperty(self, iDefinition, pchPropertyName, pchValueBuffer, punValueBufferSizeOut);
            public SteamAPICall RequestEligiblePromoItemDefinitionsIDs(SteamId steamID) => ISteamInventory.RequestEligiblePromoItemDefinitionsIDs(self, steamID);
            public bool GetEligiblePromoItemDefinitionIDs(SteamId steamID, SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize) => ISteamInventory.GetEligiblePromoItemDefinitionIDs(self, steamID, pItemDefIDs, punItemDefIDsArraySize);
            public SteamAPICall StartPurchase(SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength) => ISteamInventory.StartPurchase(self, pArrayItemDefs, punArrayQuantity, unArrayLength);
            public SteamAPICall RequestPrices() => ISteamInventory.RequestPrices(self);
            public uint GetNumItemsWithPrices() => ISteamInventory.GetNumItemsWithPrices(self);
            public bool GetItemsWithPrices(SteamItemDef* pArrayItemDefs, ulong* pCurrentPrices, ulong* pBasePrices, uint unArrayLength) => ISteamInventory.GetItemsWithPrices(self, pArrayItemDefs, pCurrentPrices, pBasePrices, unArrayLength);
            public bool GetItemPrice(SteamItemDef iDefinition, ulong* pCurrentPrice, ulong* pBasePrice) => ISteamInventory.GetItemPrice(self, iDefinition, pCurrentPrice, pBasePrice);
            public SteamInventoryUpdateHandle StartUpdateProperties() => ISteamInventory.StartUpdateProperties(self);
            public bool RemoveProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName) => ISteamInventory.RemoveProperty(self, handle, nItemID, pchPropertyName);
            public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, UTF8StringPtr pchPropertyValue) => ISteamInventory.SetProperty(self, handle, nItemID, pchPropertyName, pchPropertyValue);
            public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, bool bValue) => ISteamInventory.SetProperty(self, handle, nItemID, pchPropertyName, bValue);
            public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, long nValue) => ISteamInventory.SetProperty(self, handle, nItemID, pchPropertyName, nValue);
            public bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, float flValue) => ISteamInventory.SetProperty(self, handle, nItemID, pchPropertyName, flValue);
            public bool SubmitUpdateProperties(SteamInventoryUpdateHandle handle, SteamInventoryResult* pResultHandle) => ISteamInventory.SubmitUpdateProperties(self, handle, pResultHandle);
            public bool InspectItem(SteamInventoryResult* pResultHandle, UTF8StringPtr pchItemToken) => ISteamInventory.InspectItem(self, pResultHandle, pchItemToken);
        }
    }
}