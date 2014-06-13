using UnityEngine;
using System.Collections;

namespace GameManager
{
    public class PrefabManager : MonoBehaviour
    {
        #region Setters
        public GameObject playerPrefab;
        #endregion
        #region References
        public static GameObject _playerPrefab;
        #endregion

        void Start()
        {
            _playerPrefab = playerPrefab;
        }
    }
}
