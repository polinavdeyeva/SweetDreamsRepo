using UnityEngine;
using System.Collections;

public class P2Move : PlayerMove {

	public override void Update () {
		calculateMovement("HorizontalP2", "J2");
		base.Update ();
	}
}

