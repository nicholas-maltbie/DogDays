using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public GameObject [] displays;
	public GameObject def;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void HideAll () {
		foreach (GameObject display in displays) {
			display.SetActive(false);
		}
	}
	
	public void RestoreDefault () {
		HideAll();
		def.SetActive(true);
	}
}
