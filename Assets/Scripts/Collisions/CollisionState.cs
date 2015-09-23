using UnityEngine;
using System.Collections;

public class CollisionState : MonoBehaviour {

	public LayerMask collisionLayer;
	public bool standing;
	public Vector2 bottomPosition = Vector2.zero;
	public float collisionRadius = 10f;

	//Using Gizmos to draw lines between objects for debuging
	public Color debugCollisionColor = Color.red;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		var pos = bottomPosition;
		pos.x += transform.position.x;
		pos.y += transform.position.y;

		//return true if if it is overlapped, false otherwise.
		standing = Physics2D.OverlapCircle (pos, collisionRadius, collisionLayer);
	}

	void onDrawGizmos(){
		Gizmos.color = debugCollisionColor;

		var pos = bottomPosition;
		pos.x += transform.position.x;
		pos.y += transform.position.y;

		Gizmos.DrawWireSphere (pos, collisionRadius);
	}
}
