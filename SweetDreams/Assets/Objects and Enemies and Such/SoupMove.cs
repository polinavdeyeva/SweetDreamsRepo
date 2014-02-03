using UnityEngine;
using System.Collections;

public class SoupMove : MonoBehaviour {
	public Transform prefab;
	GameObject P1;
	GameObject P2;
	Vector3 pos = new Vector3(); 
	bool check = false;
	
	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
		pos = transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		if((transform.localPosition.x + 30f) <= (P1.transform.localPosition.x) || (transform.localPosition.x + 30f) <= (P2.transform.localPosition.x)){
			pos.z = 0f;
			if(pos.z == 0){
				check = true;
			}
		}
		if(check == true){
			pos.x += 0.26f;
		}


		transform.localPosition = pos;
		
		
	}
	void OnTriggerEnter(Collider other){
		PlayerMove Pove = other.gameObject.GetComponent<PlayerMove>();
		if (Pove != null) {
			print("SOMETHING HAPPENED ITS CALLED A COLLISION!");
			Pove.RemoveHealth ();
			Pove.RemoveHealth ();
			Pove.RemoveHealth ();
		}
	}
}
