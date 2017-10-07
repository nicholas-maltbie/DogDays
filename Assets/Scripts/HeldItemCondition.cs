using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItemCondition : Condition {

	public string itemName;

	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player != null) {
			this.satisfied = player.GetComponent<Inventory> ().HasItemWithName (itemName);
		} else {
			this.satisfied = false;
		}
	}
}
