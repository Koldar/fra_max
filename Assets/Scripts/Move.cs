using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	private Vector3 movement;


	public Vector2 speed;
	public Vector2 direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
	}

	void FixedUpdate(){
		rigidbody2D.velocity = this.movement;
	}
}
