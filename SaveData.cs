using System.Collections.Generic;


namespace meekobytes
{
    [System.Serializable]
    public class SaveData
    {
        public List<string> activeItemsList;
        public List<string> collectedItems;

        public SerializableDictionary<string, ItemPickUpSaveData> activeItemsDictionary;

        public SerializableDictionary<string, InventorySaveData> chestDictionary;

        public InventorySaveData playerInventory;

        public PlayerData playerSaveData;

        public List<string> characterInteractionsList;

        public SaveData()
        {
            activeItemsList = new List<string>();
            collectedItems = new List<string>();
            activeItemsDictionary = new SerializableDictionary<string, ItemPickUpSaveData>();
            chestDictionary = new SerializableDictionary<string, InventorySaveData>();

            playerInventory = new InventorySaveData();
            playerSaveData = new PlayerData();


        }
    }
}