using UnityEngine;
using System.Collections;

public class P1Move : PlayerMove {
	
	// Update is called once per frame
	public override void Update () {
		calculateMovement("HorizontalP1", "J1");

		base.Update ();
	}	
}

