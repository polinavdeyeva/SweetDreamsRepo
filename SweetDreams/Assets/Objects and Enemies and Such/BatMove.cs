using UnityEngine;
using System.Collections;

public class BatMove : MonoBehaviour {
	public Transform prefab;
	GameObject P1;
	GameObject P2;
	Vector3 pos = new Vector3(); 
	
	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
		pos = transform.localPosition;
		pos.y = 20f;
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if((transform.localPosition.x - 6f) <= (P1.transform.localPosition.x) || (transform.localPosition.x - 6f) <= (P2.transform.localPosition.x)){
			pos.x -= 0.5f;
			pos.y -= 0.5f;
		}
		transform.localPosition = pos;*/
		if(pos.y < 20f && pos.y > 5f){
			pos.y -= 0.1f;
		}
		if(pos.y <= 20f && pos.y >= 5f){
			pos.y += 0.1f;
		}
		transform.localPosition = pos;

		
		
	}
	void OnTriggerEnter(Collider other){
		PlayerMove Pove = other.gameObject.GetComponent<PlayerMove>();
		Pove.RemoveHealth ();
	}
}
