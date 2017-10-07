using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {

	public DogNav looking;
	public GameObject selected;
	public float lookDist = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D[] poss = Physics2D.CircleCastAll(transform.position, 0.25f, looking.look, lookDist);
		int i = 0;
		while (i < poss.Length && poss [i].collider.gameObject == gameObject && 
			poss [i].collider.gameObject.GetComponent<Interactable> () == null) {
			i += 1;
		}
		GameObject next = null;
		if (i < poss.Length) {
			RaycastHit2D hit = poss [i];
			if (hit != null && hit.collider != null) {
				if (hit.collider.gameObject.GetComponent<Interactable> () != null) {
					next = hit.collider.gameObject;
				}
			}
		}
		if (selected == null && next != null) {
			selected = next;
			selected.GetComponent<Interactable> ().selected = true;
		} else if (selected == null && next == null) {
			//do nothing
		} else if (selected != null && next == null) {
			selected.GetComponent<Interactable> ().selected = false;
			selected = null;
		} else if (selected != null && next != null) {
			if (selected != next) {
				selected.GetComponent<Interactable> ().selected = false;
				next.GetComponent<Interactable> ().selected = true;
				selected = next;
			}
		}


	}
}
