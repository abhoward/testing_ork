using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	public Animator anim;
	private bool keyEnabled = true;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void OnConversationStart() {
		anim.enabled = false;
		keyEnabled = false;
	}

	void OnConversationEnd() {
		anim.enabled = true;
		keyEnabled = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A) && keyEnabled) {
			anim.SetBool("Left", true);
			anim.SetBool("Right", false);
			anim.SetBool("Down", false);
			anim.SetBool("Up", false);
		}

		if (Input.GetKey(KeyCode.S) && keyEnabled) {
			anim.SetBool("Down", true);
			anim.SetBool("Right", false);
			anim.SetBool("Left", false);
			anim.SetBool("Up", false);
		}

		if (Input.GetKey(KeyCode.W) && keyEnabled) {
			anim.SetBool("Up", true);
			anim.SetBool("Right", false);
			anim.SetBool("Down", false);
			anim.SetBool("Left", false);
		}

		if (Input.GetKey(KeyCode.D) && keyEnabled) {
			anim.SetBool("Right", true);
			anim.SetBool("Left", false);
			anim.SetBool("Down", false);
			anim.SetBool("Up", false);
		}

		if (Input.GetKey(KeyCode.A) && keyEnabled) {
			anim.SetBool("WalkLeft", true);
		} else {
			anim.SetBool("WalkLeft", false);
		}
		if (Input.GetKey(KeyCode.S) && keyEnabled) {
			anim.SetBool("WalkDown", true);
		} else {
			anim.SetBool("WalkDown", false);
		}
		if (Input.GetKey(KeyCode.W) && keyEnabled) {
			anim.SetBool("WalkUp", true);
		} else {
			anim.SetBool("WalkUp", false);
		}
		if (Input.GetKey(KeyCode.D)	&& keyEnabled) {
			anim.SetBool("WalkRight", true);
		} else {
			anim.SetBool("WalkRight", false);
		}
	}
}
