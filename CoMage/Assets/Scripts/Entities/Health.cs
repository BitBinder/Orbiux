using UnityEngine;
using System.Collections;

public class Health : IHealth {
	private float _health;
    private BaseEntity _entity;

	#region IHealth implementation

	public Health(BaseEntity entity){
		_health = 100f;
        _entity = entity;
	}

	public Health(float starting, BaseEntity entity){
		_health = starting;
        _entity = entity;
	}

	public void HealEntity (float amount)
	{
		this._health += amount;
	}

	public void DamageEntity (float amount)
	{
		this._health -= amount;
        if (this._health <= 0)
        {
            
        }
	}

	public float GetHealth ()
	{

		return this._health;
	}

	#endregion



}
