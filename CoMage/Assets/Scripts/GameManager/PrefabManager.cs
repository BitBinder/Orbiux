using UnityEngine;
using System.Collections;

namespace GameManager
{
    public class PrefabManager : MonoBehaviour
    {
        #region Setters
        public GameObject playerPrefab;
        public GameObject obstaclePrefab;
        #endregion
        #region References
        public static GameObject _playerPrefab;
        public static GameObject _obstaclePrefab;
        #endregion

        void Start()
        {
            _playerPrefab = playerPrefab;
            _obstaclePrefab = obstaclePrefab;
        }
    }
}
