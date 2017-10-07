using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {

	public SpriteRenderer[] renderList = new SpriteRenderer[4];
	public SpriteRenderer[] slotList = new SpriteRenderer[4];
	public Sprite[] spriteList = new Sprite[4];

	public Sprite slotSprite = new Sprite();
	public Sprite bgSprite;

	public int selectedIndex = 0;

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
			// scale and place items in inventory
			if (spriteList [i] != null) {
				renderList [i].sprite = spriteList [i];
				float height = renderList [i].sprite.bounds.size.y;
				float width = renderList [i].sprite.bounds.size.x;

				float slotHeight = slotList [0].sprite.bounds.size.y;
				float slotWidth = slotList [0].sprite.bounds.size.x;

				float scaleWidth = slotWidth / width * 0.8f;
				float scaleHeight = slotHeight / height * 0.8f;

				if (scaleWidth > scaleHeight) {
					renderList [i].transform.localScale = new Vector2 (scaleHeight, scaleHeight);
				} else {
					renderList [i].transform.localScale = new Vector2 (scaleWidth, scaleWidth);
				}
			} else {
				renderList [i].sprite = null;
			}
			if (i == selectedIndex) {
				slotList [i].sprite = slotSprite;
			} else {
				slotList [i].sprite = bgSprite;
			}
		}
	}
}
