using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public Item[] items = new Item[4];
	public int selected = 0;
	private GameObject held;

	// Use this for initialization
	void Start () {
		held = new GameObject ();
		held.transform.parent = gameObject.transform;
		held.SetActive (false);
	}

	public bool HasOpen() {
		for (int i = 0; i < items.Length; i++) {
			if (items [i] == null) {
				return true;
			}
		}
		return false;
	}

	public bool DropItem(int index) {
		if (items [index] != null) {
			items [index].transform.parent = null;
			items [index].transform.position = gameObject.transform.position;
			items [index] = null;
			return true;
		}
		return false;
	}

	public bool AddItem(Item item) {
		if (HasOpen ()) {
			for (int i = 0; i < items.Length; i++) {
				if (items [i] == null) {
					items [i] = item;
					item.transform.parent = held.transform;
					return true;
			}
			}
		}
		return false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Drop")) {
			DropItem (selected);
		}
	}
}
