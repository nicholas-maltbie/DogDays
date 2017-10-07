using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Object that can be interacted with by player.
/// </summary>
public class Interactable : MonoBehaviour {

	public Sprite normalSprite, selectedSprite;
	public bool selected, canSelect = true;
	public SpriteRenderer ren;

	// Use this for initialization
	void Start () {
		
	}

	virtual public void Interact(GameObject actor) {

	}

	// Update is called once per frame
	void Update () {
		if (selected) {
			ren.sprite = selectedSprite;
		} else {
			ren.sprite = normalSprite;
		}
	}
}
