using UnityEngine;
using System.Collections;


public class PlayerController : FighterController {
	// Update is called once per frame
	void Update () {
        if (!Fighter.doMovement)
            return;
		if (Input.GetKey("f")) {
			rightControlState = ControlState.Punch;
		}
        else if (Input.GetKey("c")) {
			rightControlState = ControlState.Block;
		}
        else {
			rightControlState = ControlState.Idle;
		}

		if (Input.GetKey("a")) {
			leftControlState = ControlState.Punch;
     
		}
        else if (Input.GetKey("z")) {
			leftControlState = ControlState.Block;
		}
        else {
			leftControlState = ControlState.Idle;
		}
	}
}
