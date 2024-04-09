using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamInventory
    {
        public static ISteamInventory.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamInventory_v003", CallingConvention = Platform.CC)]
        private static extern ISteamInventory.Instance Accessor();
        /// <summary></summary>
        public static Result GetResultStatus(SteamInventoryResult resultHandle) => Instance.GetResultStatus(resultHandle);
        /// <summary></summary>
        public static bool GetResultItems(SteamInventoryResult resultHandle, SteamItemDetails* pOutItemsArray, uint* punOutItemsArraySize) => Instance.GetResultItems(resultHandle, pOutItemsArray, punOutItemsArraySize);
        /// <summary></summary>
        public static bool GetResultItemProperty(SteamInventoryResult resultHandle, uint unItemIndex, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut) => Instance.GetResultItemProperty(resultHandle, unItemIndex, pchPropertyName, pchValueBuffer, punValueBufferSizeOut);
        /// <summary></summary>
        public static uint GetResultTimestamp(SteamInventoryResult resultHandle) => Instance.GetResultTimestamp(resultHandle);
        /// <summary></summary>
        public static bool CheckResultSteamID(SteamInventoryResult resultHandle, SteamId steamIDExpected) => Instance.CheckResultSteamID(resultHandle, steamIDExpected);
        /// <summary></summary>
        public static void DestroyResult(SteamInventoryResult resultHandle) => Instance.DestroyResult(resultHandle);
        /// <summary></summary>
        public static bool GetAllItems(SteamInventoryResult* pResultHandle) => Instance.GetAllItems(pResultHandle);
        /// <summary></summary>
        public static bool GetItemsByID(SteamInventoryResult* pResultHandle, SteamItemInstanceID* pInstanceIDs, uint unCountInstanceIDs) => Instance.GetItemsByID(pResultHandle, pInstanceIDs, unCountInstanceIDs);
        /// <summary></summary>
        public static bool SerializeResult(SteamInventoryResult resultHandle, void* pOutBuffer, uint* punOutBufferSize) => Instance.SerializeResult(resultHandle, pOutBuffer, punOutBufferSize);
        /// <summary></summary>
        public static bool DeserializeResult(SteamInventoryResult* pOutResultHandle, void* pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE) => Instance.DeserializeResult(pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
        /// <summary></summary>
        public static bool GenerateItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength) => Instance.GenerateItems(pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
        /// <summary></summary>
        public static bool GrantPromoItems(SteamInventoryResult* pResultHandle) => Instance.GrantPromoItems(pResultHandle);
        /// <summary></summary>
        public static bool AddPromoItem(SteamInventoryResult* pResultHandle, SteamItemDef itemDef) => Instance.AddPromoItem(pResultHandle, itemDef);
        /// <summary></summary>
        public static bool AddPromoItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayItemDefs, uint unArrayLength) => Instance.AddPromoItems(pResultHandle, pArrayItemDefs, unArrayLength);
        /// <summary></summary>
        public static bool ConsumeItem(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemConsume, uint unQuantity) => Instance.ConsumeItem(pResultHandle, itemConsume, unQuantity);
        /// <summary></summary>
        public static bool ExchangeItems(SteamInventoryResult* pResultHandle, SteamItemDef* pArrayGenerate, uint* punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID* pArrayDestroy, uint* punArrayDestroyQuantity, uint unArrayDestroyLength) => Instance.ExchangeItems(pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
        /// <summary></summary>
        public static bool TransferItemQuantity(SteamInventoryResult* pResultHandle, SteamItemInstanceID itemIdSource, uint unQuantity, SteamItemInstanceID itemIdDest) => Instance.TransferItemQuantity(pResultHandle, itemIdSource, unQuantity, itemIdDest);
        /// <summary></summary>
        public static void SendItemDropHeartbeat() => Instance.SendItemDropHeartbeat();
        /// <summary></summary>
        public static bool TriggerItemDrop(SteamInventoryResult* pResultHandle, SteamItemDef dropListDefinition) => Instance.TriggerItemDrop(pResultHandle, dropListDefinition);
        /// <summary></summary>
        public static bool TradeItems(SteamInventoryResult* pResultHandle, SteamId steamIDTradePartner, SteamItemInstanceID* pArrayGive, uint* pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID* pArrayGet, uint* pArrayGetQuantity, uint nArrayGetLength) => Instance.TradeItems(pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
        /// <summary></summary>
        public static bool LoadItemDefinitions() => Instance.LoadItemDefinitions();
        /// <summary></summary>
        public static bool GetItemDefinitionIDs(SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize) => Instance.GetItemDefinitionIDs(pItemDefIDs, punItemDefIDsArraySize);
        /// <summary></summary>
        public static bool GetItemDefinitionProperty(SteamItemDef iDefinition, UTF8StringPtr pchPropertyName, char* pchValueBuffer, uint* punValueBufferSizeOut) => Instance.GetItemDefinitionProperty(iDefinition, pchPropertyName, pchValueBuffer, punValueBufferSizeOut);
        /// <summary></summary>
        public static SteamAPICall RequestEligiblePromoItemDefinitionsIDs(SteamId steamID) => Instance.RequestEligiblePromoItemDefinitionsIDs(steamID);
        /// <summary></summary>
        public static bool GetEligiblePromoItemDefinitionIDs(SteamId steamID, SteamItemDef* pItemDefIDs, uint* punItemDefIDsArraySize) => Instance.GetEligiblePromoItemDefinitionIDs(steamID, pItemDefIDs, punItemDefIDsArraySize);
        /// <summary></summary>
        public static SteamAPICall StartPurchase(SteamItemDef* pArrayItemDefs, uint* punArrayQuantity, uint unArrayLength) => Instance.StartPurchase(pArrayItemDefs, punArrayQuantity, unArrayLength);
        /// <summary></summary>
        public static SteamAPICall RequestPrices() => Instance.RequestPrices();
        /// <summary></summary>
        public static uint GetNumItemsWithPrices() => Instance.GetNumItemsWithPrices();
        /// <summary></summary>
        public static bool GetItemsWithPrices(SteamItemDef* pArrayItemDefs, ulong* pCurrentPrices, ulong* pBasePrices, uint unArrayLength) => Instance.GetItemsWithPrices(pArrayItemDefs, pCurrentPrices, pBasePrices, unArrayLength);
        /// <summary></summary>
        public static bool GetItemPrice(SteamItemDef iDefinition, ulong* pCurrentPrice, ulong* pBasePrice) => Instance.GetItemPrice(iDefinition, pCurrentPrice, pBasePrice);
        /// <summary></summary>
        public static SteamInventoryUpdateHandle StartUpdateProperties() => Instance.StartUpdateProperties();
        /// <summary></summary>
        public static bool RemoveProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName) => Instance.RemoveProperty(handle, nItemID, pchPropertyName);
        /// <summary></summary>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, UTF8StringPtr pchPropertyValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, pchPropertyValue);
        /// <summary></summary>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, bool bValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, bValue);
        /// <summary></summary>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, long nValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, nValue);
        /// <summary></summary>
        public static bool SetProperty(SteamInventoryUpdateHandle handle, SteamItemInstanceID nItemID, UTF8StringPtr pchPropertyName, float flValue) => Instance.SetProperty(handle, nItemID, pchPropertyName, flValue);
        /// <summary></summary>
        public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle handle, SteamInventoryResult* pResultHandle) => Instance.SubmitUpdateProperties(handle, pResultHandle);
        /// <summary></summary>
        public static bool InspectItem(SteamInventoryResult* pResultHandle, UTF8StringPtr pchItemToken) => Instance.InspectItem(pResultHandle, pchItemToken);
    }
}