using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class SaveGameTester : MonoBehaviour
    {
        public void SaveGame(SaveData data)
        {
            SaveLoad.Save(data);
        }

        public void LoadGame()
        {
            SaveLoad.Load();
        }

        public void DeleteSave()
        {
            SaveLoad.DeleteSaveData();
        }
    }

}