using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationInteract : Interactable {

	public Animation anim;
	public AnimationClip clip;
	public Condition satisfy;
	public int numTriggers = 1;

	public override void Interact(GameObject actor) {
		if (numTriggers > 0) {
			anim.clip = clip;
			anim.Play ();
			satisfy.satisfied = true;
			numTriggers--;
		}
	}
}
