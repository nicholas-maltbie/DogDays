using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveItemInteract : Interactable {

	public bool givenItem = false;
	public GameObject itemToGive;

	public override void Interact(GameObject actor) {
		if (!givenItem) {
			GameObject itemToGive = Instantiate (this.itemToGive);
			actor.GetComponent<Inventory> ().AddItem (itemToGive.GetComponent<Item> ());
			givenItem = true;
		}
	}
}
