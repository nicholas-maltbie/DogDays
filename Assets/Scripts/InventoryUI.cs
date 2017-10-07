using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {

	public SpriteRenderer[] renderList = new SpriteRenderer[4];
	public GameObject[] objList = new GameObject[4];
	public Sprite[] spriteList = new Sprite[4];

	public bool AddSprite(Sprite sprite) {
		for (int i = 0; i < 4; i++) {
			if (spriteList[i] != null) {
				spriteList[i] = sprite;
				return true;
			}
		}
		return false;
	}

	public bool RemoveSprite(int index) {
		if (spriteList[index] != null) {
			spriteList[index] = null;
			return true;
		}
		return false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 4; i++) {
			objList[i].transform.localScale = new Vector3(2.0f, 2.0f);
			renderList[i].sprite = spriteList[i];
		}
	}
}
