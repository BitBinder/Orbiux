using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameManager
{
    public class Globals : MonoBehaviour
    {
        public List<Entity> gameEntites;
        public static Globals instance;

        void Awake()
        {
            instance = this;
            gameEntites = new List<Entity>();
        }
    }
}
