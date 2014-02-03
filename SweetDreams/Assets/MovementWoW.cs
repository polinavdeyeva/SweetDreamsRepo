using UnityEngine;
using System.Collections;

public class MovementWoW : MonoBehaviour {
	Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = this.gameObject.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("HorizontalP2") == 0) {
			animator.SetBool ("isWalking", true);
			print ("WOW SHOULD BE WALKING");
			
		}
		if (Input.GetAxis ("HorizontalP2") != 0) {
			animator.SetBool("isWalking", false);
			print("WOW SHOULD NOT BE WALKING");
		}
		
			
	}
}