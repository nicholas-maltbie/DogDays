using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumeItemInteract : Interactable {

	public string consumed;
	public Condition satisfy;

	public override void Interact(GameObject actor) {
		if (actor.GetComponent<Inventory> ().HasItemWithName (consumed)) {
			Destroy (actor.GetComponent<Inventory> ().RemoveItemWithName (consumed));
			satisfy.satisfied = true;
		}
	}
}
