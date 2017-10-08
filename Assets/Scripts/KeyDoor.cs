using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : Door {

	public string key;

	public override void Interact(GameObject actor) {
		if (actor.GetComponent<Inventory> ().HasItemWithName (key)) {
			base.Interact (actor);
			Destroy (actor.GetComponent<Inventory> ().RemoveItemWithName (key));
		}
	}
}
