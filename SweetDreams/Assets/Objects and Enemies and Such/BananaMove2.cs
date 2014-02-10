using UnityEngine;
using System.Collections;

public class BananaMove2 : MonoBehaviour {
	public Transform prefab;
	GameObject P1;
	GameObject P2;
	Vector3 pos = new Vector3(0f,0f,0f); 
	public int random;
	public bool isMoving;
	
	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
		pos = transform.localPosition;
		random = Random.Range (1, 4);
	}
	
	// Update is called once per frame
	void Update () {
		/*if((transform.localPosition.x - 6f) <= (P1.transform.localPosition.x) || (transform.localPosition.x - 6f) <= (P2.transform.localPosition.x)){
			pos.y -= 0.25f;
			
		}*/

		if(!isMoving){
			
			if (random == 1) {
				if((transform.localPosition.x - 6f) <= (P1.transform.localPosition.x) || (transform.localPosition.x - 6f) <= (P2.transform.localPosition.x)){
					pos.x = -0.5f;
					pos.y = -0.5f;
					isMoving=true;
				}
			}
			if (random == 2) {
				if((transform.localPosition.x - 6f) <= (P1.transform.localPosition.x) || (transform.localPosition.x - 6f) <= (P2.transform.localPosition.x)){
					pos.y = -0.5f;
					pos.x = 0f;
					isMoving=true;
				}
			}
			if (random == 3) {
				if((transform.localPosition.x + 6f) <= (P1.transform.localPosition.x) || (transform.localPosition.x + 6f) <= (P2.transform.localPosition.x)){
					pos.x = 0.5f;
					pos.y = -0.5f;
					isMoving=true;
				}
			}
		}
		
		else{
			
			transform.localPosition += pos;
		}
		
	}
	void OnTriggerEnter(Collider other){
		PlayerMove Pove = other.gameObject.GetComponent<PlayerMove>();
		Pove.RemoveHealth ();
	}
}
