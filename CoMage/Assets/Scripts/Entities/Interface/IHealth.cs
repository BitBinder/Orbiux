using UnityEngine;
using System.Collections;

public interface IHealth {

	void HealEntity(float amount);
	void DamageEntity(float amount);
	float GetHealth();


}
