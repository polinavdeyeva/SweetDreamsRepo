//this is a comment
using UnityEngine;
using System.Collections;

public class Cave : MonoBehaviour {
	GameObject P1;
	GameObject P2;

	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("P1");
		P2 = GameObject.Find ("P2");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		Application.LoadLevel (3);
	}
}
