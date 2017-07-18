using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {
public float speed = 500;
private Rigidbody2D rb;
private Animator anim;
// private bool keyEnabled = true;
	
	// void Awake() {
		// dialogue = ModalPanel.Instance();
		// displayManager = DisplayManager.Instance();

		// myYesAction = new UnityAction (TestYesFunction);
		// myNoAction = new UnityAction (TestNoFunction);
		// myCancelAction = new UnityAction (TestCancelFunction);
	// }
	
	void Start () {
		//GameObject mario = GameObject.Find("mario");
		// mySpriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// void OnConversationStart() {
		// anim.enabled = false;
		// keyEnabled = false;
	// }

	// void OnConversationEnd() {
	// 	anim.enabled = true;
	// 	keyEnabled = true;
	// }

	// public void TestYNC() {
	// 	dialogue.Choice("u want sum fuk?\npretty plz", myYesAction, myNoAction, myCancelAction);
	// }

	// void OnCollisionEnter2D(Collision2D collision) {
	// 	if (collision.transform.gameObject.name.Contains("npc")) {
	// 		npc_collided = true;
	// 	}
	// }

	// void OnCollisionExit2D(Collision2D collision) {
	// 	if (collision.transform.gameObject.name.Contains("npc")) {
	// 		npc_collided = false;
	// 	}
	// }

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)) {
			MoveUp();
		}
		if(Input.GetKey(KeyCode.A)) {
			MoveLeft();
		}
		if(Input.GetKey(KeyCode.S)) {
			MoveDown();
		}
		if(Input.GetKey(KeyCode.D)) {
			MoveRight();
		}
			// if(Input.GetKeyDown(KeyCode.Space) && npc_collided && !npc_talk) {
			// 	// dialogue.OpenPanel();
			// 	// rb.constraints = RigidbodyConstraints2D.FreezeAll;
			// 	// npc_talk = true;
			// 	// anim.enabled = false;
			// } 
			// else if(Input.GetKeyDown(KeyCode.Space) && npc_collided && npc_talk) {
			// 	// dialogue.ClosePanel();
			// 	// npc_talk = false;
			// 	// rb.constraints = RigidbodyConstraints2D.None;
			// 	// rb.constraints = RigidbodyConstraints2D.FreezeRotation;
			// 	// anim.enabled = true;
			// }
		if(rb.velocity == Vector2.zero && 
		(Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.A) | 
		Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.D))) {
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("walk_down"))
			{
				anim.Play("idle_down", 0, 0f);
				anim.speed = 0;
			}
			else if(anim.GetCurrentAnimatorStateInfo(0).IsName("walk_up")) 
			{
				anim.Play("idle_up", 0, 0f);
				anim.speed = 0;
			}
			else if(anim.GetCurrentAnimatorStateInfo(0).IsName("walk_right")) 
			{
				anim.Play("idle_right", 0, 0f);
				anim.speed = 0;
			}
			else if(anim.GetCurrentAnimatorStateInfo(0).IsName("walk_left")) 
			{
				anim.Play("idle_left", 0, 0f);
				anim.speed = 0;
			}
		} else anim.speed = 1;
	}

	void MoveLeft() {
		rb.AddForce(Vector2.left * speed);
		// mySpriteRenderer.flipX = true;
		// Vector2 pos = this.transform.position;
		// pos.x = pos.x - (1*speed);
		// this.transform.position = pos;
	}

	void MoveRight() {
		rb.AddForce(Vector2.right * speed);
		// mySpriteRenderer.flipX = false;
		// Vector2 pos = this.transform.position;
		// pos.x = pos.x + (1*speed);
		// this.transform.position = pos;
	}

	void MoveUp() {
		rb.AddForce(Vector2.up * speed);
		// Vector2 pos = this.transform.position;
		// pos.y = pos.y + (1*speed);
		// this.transform.position = pos;
	}

	void MoveDown() {
		rb.AddForce(Vector2.down * speed);
		// Vector2 pos = this.transform.position;
		// pos.y = pos.y - (1*speed);
		// this.transform.position = pos;
	}

	// void TestYesFunction () {
	// 	displayManager.DisplayMessage("WAOW");
	// }

	// void TestNoFunction () { 
	// 	displayManager.DisplayMessage("NAOW");
	// }

	// void TestCancelFunction () {
	// 	displayManager.DisplayMessage("FUCK");
	// }
}