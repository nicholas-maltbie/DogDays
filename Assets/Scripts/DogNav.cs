using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogNav : MonoBehaviour {

	public float moveSpeed = 1.0f;
	public Animator spriteAnimator;
	public Rigidbody2D rb2d;
	public Vector3 look = Vector3.up;

	private float idleTime = 0.0f, idleReset = 10.0f;

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

		rb2d.velocity = move * moveSpeed;

		if (move != Vector3.zero) {
			idleTime = 0;
			spriteAnimator.SetFloat ("x", move.x);
			spriteAnimator.SetFloat ("y", move.y);
			look = new Vector3 (move.x, move.y);
			spriteAnimator.SetBool ("walk", true);
		} else {
			idleTime += Time.deltaTime;
			spriteAnimator.SetBool ("walk", false);
			if (idleTime >= idleReset) {
				spriteAnimator.SetFloat ("x", 0);
				spriteAnimator.SetFloat ("y", 0);
				look = new Vector3 (0, 0);
			}
		}
	}
}
