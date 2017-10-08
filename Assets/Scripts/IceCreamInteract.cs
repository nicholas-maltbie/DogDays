using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamInteract : Interactable {

	public string consumed;
	public Condition satisfy;
	public GameObject girl;
	public Sprite girlHappy, girlHappySel;

	public override void Interact(GameObject actor) {
		if (actor.GetComponent<Inventory> ().HasItemWithName (consumed)) {
			Destroy (actor.GetComponent<Inventory> ().RemoveItemWithName (consumed));
			satisfy.satisfied = true;
			Destroy (girl.GetComponent< HeldItemCondition > ());
			Destroy (girl.GetComponent< InteractTask > ());
			girl.GetComponent<SpriteRenderer> ().sprite = girlHappy;
			InteractionDialogue dia = girl.GetComponent < InteractionDialogue >();
			dia.dialogue = "Thanks for the ice cream!";
			dia.icon = girlHappy;
			dia.normalSprite = girlHappy;
			dia.selectedSprite = girlHappySel;
			
		}
	}
}
