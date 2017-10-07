using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogNav : MonoBehaviour {

	public float moveSpeed = 1.0f;

	void OnCollisionEnter2D(Collision2D coll)
	{

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horiz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");

		Vector3 move = new Vector3 (horiz, vert).normalized;

		transform.Translate (move * Time.deltaTime * moveSpeed);
	}
}
