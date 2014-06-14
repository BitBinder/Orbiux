using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

		public void RemoveEntityFromList(Entity entity){
			gameEntites.RemoveAll(i => i == entity);
			Destroy(entity.GetGamePrefab());

		}
    }
}
