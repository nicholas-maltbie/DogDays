using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCharacter : MonoBehaviour {

	public GameObject dogPrefab;
	public Transform spawn;

	// Use this for initialization
	void Start () {
		if (GameObject.FindGameObjectsWithTag ("Player").Length == 0) {
			Instantiate (dogPrefab);
			dogPrefab.transform.position = spawn.position;
			//Scenes.AddScene ("Apartment", SceneManager.GetActiveScene ());
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
