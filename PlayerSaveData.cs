using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace meekobytes
{
    public class PlayerSaveData : MonoBehaviour
    {
        private int _currentHealth = 1;
        //ID / Boolean dictionary
        private List<string> InteractionsHadList;
        private PlayerData MyData = new PlayerData();

        void LateUpdate()
        {
            var transform1 = transform;
            MyData.PlayerPosition = transform1.position;
            MyData.PlayerRotation = transform1.rotation;
            MyData.CurrentHealth = _currentHealth;
            //Should be updated on the completion of an interaction.
            //MyData.InteractionsHadList = InteractionsHadList;
        }

        //Create an event to call to update the character In
    }

    [System.Serializable]
    public struct PlayerData
    {
        public Vector3 PlayerPosition;
        public Quaternion PlayerRotation;
        public int CurrentHealth;

        public List<string> InteractionsHadList;
    }
}