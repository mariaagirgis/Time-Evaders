// Ball script
// 

using UnityEngine;
using System.Collections;
using System;
using Random = UnityEngine.Random;

// Add lean touch library
using Lean.Touch;

// Ball Class
public class Ball : MonoBehaviour {

	// collision sound clip
	public AudioClip collisionSound;

	// lifetime to destroy itself
	private float lifetime = 1.0f;

	// Use this for initialization
	protected virtual void Start () {

		// random lifetime between 10 to 20 seconds
		lifetime = Random.Range(10.0f, 20.0f);

		// deselect object from the beginning
		// this will prevent it from being automatically
        // selected when it is spawned
		GetComponent<LeanSelectableByFinger>().Deselect();

	}

	void OnDestroy() {
	}

	// Update is called once per frame
	void Update () {

		// check lifetime
		lifetime -= Time.deltaTime;
		if (lifetime < 0.0f) {
			Destroy(gameObject);
		}

	}

	// Collision handling: make a bouncing sound when hit a wall
	void OnCollisionEnter2D(Collision2D target) {

		// safeguard: check if the audio clip is assigned
		if (collisionSound)
			// simple audio clip playback
			AudioSource.PlayClipAtPoint(collisionSound, transform.position);
	}

	// method to split a ball to two balls
	public void Split()
	{
		
		// break ball!
		if (transform.localScale.x > 0.32f)
		{
			// random color
			Color color = new Color(Random.value, Random.value, Random.value);

			// forcefully deselect object from touch
			// otherwise, some odd behavior occurs (?)
			// for example, splitted chidren are select to begin with
			// as they were instanticated from this one
			GetComponent<LeanSelectableByFinger> ().Deselect ();

			// break this ball into 2 balls
			for (int i = 0; i < 2; i++)
			{
				// clone object
				var obj = Instantiate(gameObject) as GameObject;
				var ball = obj.transform;
				ball.parent = transform.parent;
				ball.name = "Ball";

				// make it smaller: 75%
				ball.localScale = 0.75f * transform.localScale;

				// set position: left and right
				ball.position = transform.TransformPoint((i - 0.5f)*ball.localScale.x*1.5f, 0f, 0f);

				// add some force
				ball.GetComponent<Rigidbody2D>().AddForce(0.1f * Random.insideUnitCircle);

				// assign random color
				ball.GetComponent<Renderer>().material.color = color;

			}

			Destroy(gameObject);
		}
		else
		{
			// too small. let's get rid of it.
			Destroy(gameObject);
		}

	}

}