using UnityEngine;
using System.Collections;
using Helpers;

public class PlayerInput : IInput {

	private BaseEntity _entity;

	public PlayerInput(BaseEntity entity){
		this._entity = entity;
	}

	#region IInput implementation

	public Tuple<float, float> GetKeyBoardMovement ()
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		return new Tuple<float, float>(x,y);
	}

	#endregion
}
