using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float health = 3f;
	protected float speed = 15f;
	Vector3 moveDirection = new Vector3(0f, 0f, 0f);
	protected CharacterController controller;
	public float gravity = -9.8f;
	protected float jumpHeight = 2f;
	public float terminalVelocity = -1f;
	Vector3 variableLeft = new Vector3();
	Vector3 variableRight = new Vector3();
	Vector3 screenDim = new Vector3();
	float HorizontalMovement;
	float edgeOffset = 5.0f;
	Animator animator;
	public float defaulty;
	public float facing;
	Vector3 scaling = new Vector3(3f, 3f, 1f);
	//added a comment for testing

	// Use this for initialization
	void Start () {
		controller = transform.GetComponent<CharacterController>();
		enabled = true;
		animator = transform.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	public virtual void Update () {
		UpdateScreenVars ();
		if(moveDirection.y > terminalVelocity){
			defaulty = moveDirection.y;
			moveDirection.y += gravity *Time.deltaTime;
			if(moveDirection.y > defaulty){
				animator.SetTrigger("startJump");
			}
		}

		controller.Move (moveDirection);

	
	}
	public void UpdateScreenVars(){
		print ("Camera is " + Camera.main.pixelWidth + " pixels wide");
		screenDim.x = Camera.main.pixelWidth;
		variableRight = Camera.main.ScreenToWorldPoint (screenDim);
		print ("Right" + variableRight);
		screenDim.x = 0;
		variableLeft = Camera.main.ScreenToWorldPoint (screenDim);
		print ("Left" + variableLeft);
	}

	public void calculateMovement(string horizontalAxis, string jumpButton){
		HorizontalMovement = Input.GetAxis (horizontalAxis);

		if (transform.localPosition.x < variableRight.x - edgeOffset && HorizontalMovement > 0) {
			moveDirection.x = HorizontalMovement * Time.deltaTime * speed;
			animator.SetBool("isWalking", true);
			scaling.x = 3f;
			transform.localScale = scaling;
		}
		else if(transform.localPosition.x > variableLeft.x + edgeOffset && HorizontalMovement < 0){
			moveDirection.x = HorizontalMovement * Time.deltaTime * speed;
			animator.SetBool("isWalking", true);
			scaling.x = -3f;
			transform.localScale = scaling;
		}
		else {
			animator.SetBool("isWalking", false);
			moveDirection.x = 0;
		}
		if(Input.GetButtonDown(jumpButton)){
			if(controller.isGrounded){
				moveDirection.y = jumpHeight;
			}
		}
	}
	public void RemoveHealth(){
		health--;
		print (health);
		if (health <= 0) {
			enabled = false;
			//this.gameObject.renderer.enabled = false;
			//this.gameObject.collider.enabled = false;
			gameObject.active = false;
				}
		if (health < 0) {
			health = 0;
				}
	} 
}
