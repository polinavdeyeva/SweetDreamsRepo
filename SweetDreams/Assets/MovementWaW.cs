using UnityEngine;
using System.Collections;

public class MovementWaW : MonoBehaviour {
	Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = this.gameObject.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("HorizontalP1") == 0) {
			animator.SetBool ("isWalking", true);
			print ("WAW SHOULD BE WALKING");
			
		}
		if (Input.GetAxis ("HorizontalP1") != 0) {
			animator.SetBool("isWalking", false);
			print("WAW SHOULD NOT BE WALKING");
		}
		
		
		
	}
}
