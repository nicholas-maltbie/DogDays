using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORCondition : Condition {
	override public bool IsSatisfied() {
		foreach(Condition preCond in preConditions) {
			if (preCond.IsSatisfied()) {
				return true;
			}
		}
		return false;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
