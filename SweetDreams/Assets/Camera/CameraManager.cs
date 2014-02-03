using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {
	//public Camera camera = new Camera();
	GameObject P1;
	GameObject P2;
	Vector3 pos = new Vector3();

	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find ("WonderWomanParent");
	}
	
	// Update is called once per frame
	void Update () {
		if (P1.gameObject.active == true && P2.gameObject.active == true) {
				pos = ((P1.transform.localPosition + P2.transform.localPosition) / 2);
		}
		else if(P1.gameObject.active==true && P2.gameObject.active==false){
				pos = P1.transform.localPosition;
		}
		else if(P1.gameObject.active==false && P2.gameObject.active==true){
			pos = P2.transform.localPosition;
		}

		pos.y = 14f;
		pos.z = -10;
		transform.localPosition = pos;
	}
}
