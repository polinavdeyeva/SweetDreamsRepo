using UnityEngine;
using System.Collections;

public class FallDeath : MonoBehaviour {
	GameObject P1;
	GameObject P2;

	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		PlayerMove Pove = other.gameObject.GetComponent<PlayerMove>();
		Pove.health = 0;
		Pove.enabled = false;

	}
}
