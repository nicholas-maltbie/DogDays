using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagement : MonoBehaviour {

	public GameObject dialogueMenu;
	public Text characterName;
	public Text characterDialogue;
	public SpriteRenderer character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (character.sprite != null) {
			float height = Screen.height*0.2f;// character.sprite.bounds.size.y;
			float width = Screen.height*0.2f;// character.sprite.bounds.size.x;

			float slotHeight = character.sprite.bounds.size.y;
			float slotWidth = character.sprite.bounds.size.x;

			float scaleWidth = width / slotWidth * 0.8f;
			float scaleHeight = height / slotHeight * 0.8f;

			if (scaleWidth > scaleHeight) {
				character.transform.localScale = new Vector2 (scaleHeight, scaleHeight);
			} else {
				character.transform.localScale = new Vector2 (scaleWidth, scaleWidth);
			}
		}
	}
	
	public void OpenDialogue () {
		dialogueMenu.SetActive(true);
	}
	
	public void SetInformation (Sprite face, string name, string dialogue) {
		character.sprite = face;
		characterName.text = name;
		characterDialogue.text = dialogue;
	}
	
	public void ClearInformation () {
		character.sprite = null;
		characterName.text = "";
		characterDialogue.text = "";
	}
	
	public void CloseDialogue () {
		dialogueMenu.SetActive(false);
		GetComponent < UIManager >().RestoreDefault();
	}
}
