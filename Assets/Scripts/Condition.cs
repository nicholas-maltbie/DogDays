using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour {

	public Condition[] preConditions;
	public bool satisfied = true;

	public bool IsSatisfied() {
		foreach (Condition preCondition in preConditions) {
			if (!preCondition.IsSatisfied ()) {
				return false;
			}
		}
		return satisfied;
	}
}
