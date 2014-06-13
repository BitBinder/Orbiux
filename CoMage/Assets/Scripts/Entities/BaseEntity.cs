using UnityEngine;
using System.Collections;
using Helpers;

public class BaseEntity : IEntity {

    protected string _name;
    protected string _tag;
    protected int _priority;
    protected GameObject _prefab;
    protected GameObject _entityObject;
    protected Rigidbody2D _rigidbody;
    protected IHealth _health;
	protected IInput _input;

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetTag()
    {
        return _tag;
    }

    public void SetTag(string tag)
    {
        _tag = tag;
    }

    public void SetPriority(int priority)
    {
        _priority = priority;
    }

    public int GetPriority()
    {
        return _priority;
    }

    public void SetGamePrefab(GameObject prefab)
    {
        _prefab = prefab;
    }

    public GameObject GetGamePrefab()
    {
        return _entityObject;
    }

    public void SetRigidBody(Rigidbody2D rigidbody)
    {
        _rigidbody = rigidbody;
    }

    public Rigidbody2D GetRigidBody()
    {
        return _rigidbody;
    }

    public void SetInput(IInput input)
    {
        _input = input;
    }

    public Tuple<float, float> GetInput()
    {
        return _input.GetKeyBoardMovement();
    }

    public virtual void StartUp()
    {

    }

    public virtual void Update()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Spawn(Vector2 pos)
    {
        _entityObject = (GameObject)GameObject.Instantiate(_prefab, pos, Quaternion.identity);
        _entityObject.transform.parent = GameObject.Find("GameEntities").transform;
        _entityObject.tag = GetTag();
    }

    public virtual void CalculateItems()
    {
        throw new System.NotImplementedException();
    }

    public IHealth GetEntityHealth()
    {
        return this._health;
    }

    public void SetEntityHealth(IHealth health)
    {
        _health = health;
    }
}
