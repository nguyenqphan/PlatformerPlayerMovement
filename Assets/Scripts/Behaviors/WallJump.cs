using UnityEngine;
using System.Collections;

public class WallJump : AbstractBehavior {

	public Vector2 jumpVelocity = new Vector2(50, 200);
	
	// Update is called once per frame
	void Update () {

		if(collisionState.onWall && !collisionState.standing){

			var canJump = inputState.GetButtonValue(inputButtons[0]);

			if(canJump){

				inputState.direction = inputState.direction == Direction.Right ? Direction.Left : Direction.Right;
				body2d.velocity = new Vector2(jumpVelocity.x * (float)inputState.direction, jumpVelocity.y);
			}
		}
	}
}
