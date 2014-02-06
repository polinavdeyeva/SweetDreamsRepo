using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	GameObject P1;
	GameObject P2;
	PlayerMove player1;
	PlayerMove player2;

	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
		player1 = P1.gameObject.GetComponentInChildren<PlayerMove> ();
		player2 = P2.gameObject.GetComponentInChildren<PlayerMove> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player1.health == 0 && player2.health == 0) {
			Application.LoadLevel(4);
			print("you're dead..");
		}
	
	}
}
