using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class SaveGameManager : MonoBehaviour
    {
        public static SaveGameManager Instance;
        public static SaveData Data;
        private void Awake()
        {

            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                Data = new SaveData();
                SaveLoad.OnLoadGame += LoadData;
            }
            else
            {
                Destroy(this);
            }
        }

        public void DeleteData()
        {
            SaveLoad.DeleteSaveData();
        }

        public static void SaveData()
        {
            var saveData = Data;
            SaveLoad.Save(saveData);
        }

        public static void LoadData(SaveData _data)
        {
            Data = _data;
        }

        public static void TryLoadData()
        {
            SaveLoad.Load();
        }
    }
}