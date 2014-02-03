using UnityEngine;
using System.Collections;

public class SpikeMove : MonoBehaviour {
	public Transform prefab;
	GameObject P1;
	GameObject P2;
	Vector3 pos = new Vector3(); 
	
	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
		pos = transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		if((transform.localPosition.x - 15f) <= (P1.transform.localPosition.x) || (transform.localPosition.x - 15f) <= (P2.transform.localPosition.x)){
			pos.x -= 0.25f;
		}
		transform.localPosition = pos;
		
		
	}
	void OnTriggerEnter(Collider other){
		PlayerMove Playamove = other.gameObject.GetComponent<PlayerMove>();
		Playamove.RemoveHealth ();
	}
}
