using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable {

	public Sprite icon;
	string description, itemName;

	public override void Interact(GameObject actor) {
		actor.GetComponent<Inventory> ().AddItem (this);
	}
}
