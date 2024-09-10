using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace meekobytes
{
    public static class SaveLoad
    {
        public static UnityAction OnSaveGame;
        public static UnityAction<SaveData> OnLoadGame;

        private static string saveDirectory = "/SaveData/";
        private static string fileName = "SaveGame.sav";

        public static bool Save(SaveData data)
        {
            OnSaveGame?.Invoke();

            string dir = Application.persistentDataPath + saveDirectory;

            GUIUtility.systemCopyBuffer = dir;

            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(dir + fileName, json);

            GUIUtility.systemCopyBuffer = dir;

            return true;
        }

        public static SaveData Load()
        {
            string fullPath = Application.persistentDataPath + saveDirectory + fileName;
            SaveData data = new SaveData();

            if (File.Exists(fullPath))
            {
                string json = File.ReadAllText(fullPath);
                data = JsonUtility.FromJson<SaveData>(json);

                OnLoadGame?.Invoke(data);
            }
            else
            {
                Debug.LogError("Save file does not exist!");
            }

            return data;
        }

        public static void DeleteSaveData()
        {
            string fullPath = Application.persistentDataPath + saveDirectory + fileName;

            if (File.Exists(fullPath)) File.Delete(fullPath);
        }
    }
}
