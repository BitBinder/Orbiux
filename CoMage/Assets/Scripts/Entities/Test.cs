using UnityEngine;
using System.Collections;
using GM = GameManager;

public class Player : BaseEntity {

	public Player(){
        SetTag("Player");
        SetPriority(0);
        SetInput(new PlayerInput(this));
        SetEntityHealth(new Health(this));
        SetGamePrefab(GM.PrefabManager._playerPrefab);
        StartUp();

	}

    public override void StartUp()
    {
        base.StartUp();
        Spawn(new Vector2(0,0));
    }

	public override void Update ()
	{
        
		

	}

}
