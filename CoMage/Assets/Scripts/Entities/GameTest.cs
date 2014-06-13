using UnityEngine;
using System.Collections;

public class GameTest : MonoBehaviour {
	BaseEntity test;
	// Use this for initialization
	void Start () {
		test = new Player();

	}
	
	// Update is called once per frame
	void Update () {
		test.Update();
	}
}
