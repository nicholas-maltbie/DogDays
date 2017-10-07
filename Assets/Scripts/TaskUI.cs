using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUI : MonoBehaviour {
	public Text tasks;

	public List<string> taskList = new List<string>();

	public void AddTasks(List<string> tasks) {
		// foreach (string task in tasks) {
		// 	this.taskList.Add(task);
		// }
		this.taskList = tasks;
	}

	// Use this for initialization
	void Start () {
		// tasks = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		tasks.text = "Tasks\n";
		for (int i = 0; i < this.taskList.Count; i++) {
			tasks.text += "- " + this.taskList[i] + "\n";
		}
	}
}
