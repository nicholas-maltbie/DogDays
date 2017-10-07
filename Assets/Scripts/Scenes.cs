using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {

	public static Dictionary<string, Scene> loaded = new Dictionary<string, Scene> ();

	public static void LoadScene(string target, GameObject dog, Vector3 targetPos) {
		if (!loaded.ContainsKey (target)) {
			Scene sceneToLoad = SceneManager.GetSceneByName (target);
			DontDestroyOnLoad (dog);
			//SceneManager.LoadScene (target, LoadSceneMode.Additive);
			SceneManager.SetActiveScene (sceneToLoad);
			dog.transform.position = targetPos;
			loaded [target] = sceneToLoad;
		} else {
			Scene sceneToLoad = loaded[target];
			DontDestroyOnLoad (dog);
			SceneManager.SetActiveScene (sceneToLoad);
			dog.transform.position = targetPos;
		}
	}

	public static void AddScene(string name, Scene scene) {
		loaded [name] = scene;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
