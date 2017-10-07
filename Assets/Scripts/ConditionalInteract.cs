using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalInteract : MonoBehaviour {

	public Condition condition;
	public Interactable interactable;

	void Update() {
		interactable.canSelect = condition.IsSatisfied;
	}


}
