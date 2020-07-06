using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

	// Use this for initialization
	private bool isJump = false;
	public void ChangeJumpState(){
		if (isJump == false)
			isJump = true;
		else
			isJump = false;
	}
	public bool GetJumpState(){
		return isJump;
	}
}
