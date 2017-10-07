using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUI : MonoBehaviour {
	public struct Task {
		public string title;
		public string secondary;

		public Task(string title, string secondary) {
			this.title = title;
			this.secondary = secondary;
		}
	}

	public Text tasks;

	public List<Task> taskList = new List<Task>();

	public void AddTask(string title, string secondary) {
		this.taskList.Add(new Task(title, secondary));
	}

	// Use this for initialization
	void Start () {
		// tasks = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		tasks.text = "Tasks\n";
		for (int i = 0; i < this.taskList.Count; i++) {
			tasks.text += "- " + this.taskList[i].title + "\n";
		}
	}
}
