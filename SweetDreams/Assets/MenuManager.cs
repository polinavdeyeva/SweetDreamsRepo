using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public CharacterController input;
	GameObject P1;
	GameObject P2;
	PlayerMove player1;
	PlayerMove player2;
	//this is another comment I'm inserting because ya know reasons

	// Use this for initialization
	void Start () {
		input = GetComponent<CharacterController>();
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
		player1 = P1.gameObject.GetComponent<PlayerMove> ();
		player2 = P2.gameObject.GetComponent<PlayerMove> ();

	
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			float axis = Input.GetAxis("Jump");
				if(axis > 0){
					Application.LoadLevel(2);
				}
				else if(axis < 0){
					Application.LoadLevel(1);
				}
			}
		print (player1.health + player2.health);
		if (player1.health == 0 && player2.health == 0) {
			//Application.LoadLevel(3);
			print("you died");
				}


	
	}
}
