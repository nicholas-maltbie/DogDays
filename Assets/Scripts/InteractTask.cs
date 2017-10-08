using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTask : Interactable {

	public Condition satisfy;

	public override void Interact(GameObject actor) {
		satisfy.satisfied = true;
	}
}
