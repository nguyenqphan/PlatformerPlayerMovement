﻿using UnityEngine;
using System.Collections;

public class FaceDirection : AbstractBehavior {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var right = inputState.GetButtonValue (inputButtons[0]);
		var left = inputState.GetButtonValue (inputButtons[1]);
	
		if(right){
			//Debug.Log("Facing Right");
			inputState.direction = Direction.Right;
		}
		else if(left){
			//Debug.Log("Facing Left");
			inputState.direction = Direction.Left;
		}

		transform.localScale = new Vector3((float)inputState.direction, 1, 1);
	}
}
