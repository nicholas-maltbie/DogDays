using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamInteract : Interactable {

	public string consumed;
	public Condition satisfy;
	public GameObject girl;
	public Sprite girlHappy;

	public override void Interact(GameObject actor) {
		if (actor.GetComponent<Inventory> ().HasItemWithName (consumed)) {
			Destroy (actor.GetComponent<Inventory> ().RemoveItemWithName (consumed));
			satisfy.satisfied = true;
			Destroy (girl.GetComponent<Condition> ());
			Destroy (girl.GetComponent<Interactable> ());
			girl.GetComponent<SpriteRenderer> ().sprite = girlHappy;
		}
	}
}
