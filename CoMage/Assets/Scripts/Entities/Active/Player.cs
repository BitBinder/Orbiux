using UnityEngine;
using System.Collections;
using GameManager;

public class Player : Entity {

	public Player(){
        SetTag("Player");
        SetPriority(0);
        SetInput(new PlayerInput(this));
        SetEntityHealth(new Health(this));
        SetGamePrefab(GameManager.PrefabManager._playerPrefab);
        _speed = 10f;
        StartUp();

	}

    public override void StartUp()
    {
        base.StartUp();
        Spawn(new Vector2(0,0));
        GameManager.Globals.instance.gameEntites.Add(this);
    }

	public override void Update ()
	{
        _input.GetKeyBoardMovement();
        var x = GetInput().Item1;
        var y = GetInput().Item2;
        var movementVector = new Vector2(x, y);
        _entityObject.transform.position = Vector2.Lerp(_entityObject.transform.position, movementVector + (Vector2)_entityObject.transform.position, Time.deltaTime * _speed);
		

	}

}
