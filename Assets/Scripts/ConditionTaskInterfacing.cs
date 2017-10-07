using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionTaskInterfacing : MonoBehaviour {
	public Condition[] condList;
	public TaskUI task_ui = new TaskUI();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		List<string> tasks = new List<string>();
		condList = GameObject.FindObjectsOfType(typeof(Condition)) as Condition[];
		foreach (Condition cond in condList) {
			if (cond.IsSatisfied()) {
				
			} else {
				if (cond.preConditions.Length == 0) {
					tasks.Add(cond.taskDescription);
				} else {
					bool check = false;
					foreach (Condition preCond in cond.preConditions) {
						if (preCond.IsSatisfied() != true) {
							check = true;
							break;
						}
					}
					if (!check) {
						tasks.Add(cond.taskDescription);
					}
				}
			}
		}

		task_ui.AddTasks(tasks);
	}
}
