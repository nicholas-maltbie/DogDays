using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDialogue : Interactable {

	public Sprite icon;
	public string name;
	public string dialogue;
	
	public override void Interact(GameObject actor) {
		DialogueManagement man = actor.GetComponent < DialogueManagement >();
		if (man != null) {
			actor.GetComponent < UIManager >().HideAll();
			man.OpenDialogue();
			man.SetInformation(icon, name, dialogue);
		}
	}
}