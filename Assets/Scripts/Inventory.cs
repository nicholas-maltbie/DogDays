using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public Item[] items = new Item[4];
	public int selected = 0;
	private GameObject held;
	public InventoryUI userInterface;

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

	public bool HasItemWithName(string itemName) {
		foreach (Item item in items) {
			if (item != null && item.itemName == itemName) {
				return true;
			}
		}
		return false;
	}

	public bool RemoveItemWithName(string itemName) {
		for (int i = 0; i < 4; i++) {
			if (items [i] != null && items [i].itemName == itemName) {
				DropItem (i);
				return true;
			}
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

		if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
			selected += 1;
		} else if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			selected -= 1;
		}
		if (selected < 0) {
			selected = 3;
		} else if (selected > 3) {
			selected = 0;
		}
		if (Input.GetKeyDown ("1")) {
			selected = 0;
		} else if (Input.GetKeyDown ("2")) {
			selected = 1;
		} else if (Input.GetKeyDown ("3")) {
			selected = 2;
		} else if (Input.GetKeyDown ("4")) {
			selected = 3;
		}

		for (int i = 0; i < 4; i++) {
			if (items [i] != null) {
				userInterface.spriteList [i] = items [i].icon;
			} else {
				userInterface.spriteList [i] = null;
			}
		}
		userInterface.selectedIndex = selected;
	}
}
