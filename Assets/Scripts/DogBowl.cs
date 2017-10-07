using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBowl : Interactable {

	public Sprite emptySprite;

	public override void Interact (GameObject actor)
	{
		this.normalSprite = emptySprite;
		this.canSelect = false;
	}
}
