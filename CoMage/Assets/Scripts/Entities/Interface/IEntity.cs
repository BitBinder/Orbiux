using UnityEngine;
using System.Collections;
using Helpers;

public interface IEntity {
    float GetSpeed();
    void SetSpeed(float speed);
    string GetName();
    void SetName(string name);
	string GetTag();
	void SetTag(string tag);

	void SetPriority(int priority);
	int GetPriority();
	void SetGamePrefab(GameObject prefab);
    GameObject GetGamePrefab();
	
	void SetInput(IInput input);
	Tuple<float,float> GetInput();
    void StartUp();
	void Update();
    void Spawn(Vector2 pos);
	void CalculateItems(); //used for getting equipped bonuses. Will be a class in future.
	IHealth GetEntityHealth();
	void SetEntityHealth(IHealth health);
}
    
