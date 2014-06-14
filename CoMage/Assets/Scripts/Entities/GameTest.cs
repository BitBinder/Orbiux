using UnityEngine;
using System.Collections;
using GameManager;

public class GameTest : MonoBehaviour {
	Entity test;
	// Use this for initialization
	void Start () {
		test = new Player();
       var obstacle = new Obstacle();
        

	}
	
	// Update is called once per frame
	void Update () {
        foreach (Entity entity in GameManager.Globals.instance.gameEntites.ToArray())
        {
			if (Input.GetMouseButton(0)){
				entity.GetEntityHealth().DamageEntity(50f);
			}
            entity.Update();
        }
	}
}
