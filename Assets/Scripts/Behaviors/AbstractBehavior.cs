using UnityEngine;
using System.Collections;

public abstract class AbstractBehavior : MonoBehaviour {

	public Buttons[] inputButtons;

	protected InputState inputState;
	protected Rigidbody2D body2d;

	//make it virtual, so it can be overwritten by other class

	protected virtual void Awake(){
		inputState = GetComponent<InputState>();
		body2d = GetComponent<Rigidbody2D>();
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
