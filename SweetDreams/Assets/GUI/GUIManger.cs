using UnityEngine;
using System.Collections;

public class GUIManger : MonoBehaviour {
	public GUIText redHealth;
	public GUIText blueHealth;
	public GUIText mainmenu;
	GameObject P1;
	GameObject P2;
	PlayerMove P2Script;
	PlayerMove P1Script;
	

	// Use this for initialization
	void Start () {
		P1 = GameObject.Find("WarriorWomanParent");
		P2 = GameObject.Find("WonderWomanParent");
		P1Script = P1.GetComponent<PlayerMove>();
		P2Script = P2.GetComponent<PlayerMove>();
	}
	
	// Update is called once per frame
	void Update () {
		redHealth.text = "Red Health: " + P1Script.health;
		blueHealth.text = "Blue Health: " + P2Script.health;

		}
}
