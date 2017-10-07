using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBowl : Interactable {

	public Sprite emptySprite;
	public Condition waiting;

	public override void Interact (GameObject actor)
	{
		this.normalSprite = emptySprite;
		this.canSelect = false;
		waiting.satisfied = true;
	}
}
