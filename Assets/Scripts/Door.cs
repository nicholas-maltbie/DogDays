using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : Interactable {

	public string target;
	public Vector3 targetPos = Vector3.zero;

	public override void Interact(GameObject actor) {
		Scene sceneToLoad = SceneManager.GetSceneByName(target);
		DontDestroyOnLoad(actor);
		SceneManager.LoadSceneAsync(target, LoadSceneMode.Single);
		actor.transform.position = targetPos;
	}
}
