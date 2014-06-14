using UnityEngine;
using System.Collections;

public class Obstacle : Entity {

	public Obstacle(){
        SetTag("Obstacle");
        SetPriority(5);
        SetGamePrefab(GameManager.PrefabManager._obstaclePrefab);
        StartUp();

	}

    public override void StartUp()
    {
        base.StartUp();
        Spawn(new Vector2(5,5));
        GameManager.Globals.instance.gameEntites.Add(this);
    }
}
