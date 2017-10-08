using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public GameObject pauseMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Cancel")) {
			TogglePause();
		}
	}
	
	public void TogglePause () {
		if (Time.timeScale == 0) {
			ResumeGame();
		}
		else {
			PauseGame();
		}
	}
	
	public void PauseGame () {
		Time.timeScale = 0;
		pauseMenu.SetActive(true);
	}
	
	public void ResumeGame () {
		Time.timeScale = 1;
		pauseMenu.SetActive(false);
	}
	
	public void Quit () {
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}
	
	public void MainMenu () {
		string target = "Title";
		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			Destroy (GameObject.FindGameObjectWithTag ("Player"));
		}
		SceneManager.LoadSceneAsync(target, LoadSceneMode.Single);
	}
}
