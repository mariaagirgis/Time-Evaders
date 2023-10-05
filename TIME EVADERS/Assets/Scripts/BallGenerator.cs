using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;

// your code: add lean touch library
using Lean.Touch;

public class BallGenerator : MonoBehaviour {

	// ball prefab object
	public Transform ball;

	// ball container object: a parent transform of all balls
	public Transform container;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void SpawnBall(LeanFinger finger)
	{
		Debug.Log ("SpawnBall called");

		Vector3 touchPos = finger.GetLastWorldPosition (0);
		touchPos.z = 0f;

		// instantiate new ball object
		var obj = Instantiate(ball) as Transform;
		//obj.GetComponent<LeanSelectableByFinger>().Deselect();
		obj.parent = container;
		obj.name = "Ball";

		// initial position of newly spawned ball
		obj.position = touchPos;

		// assign random color
		Color color = new Color(Random.value, Random.value, 1.0f);
		obj.GetComponent<SpriteRenderer>().color = color;

	}

}
