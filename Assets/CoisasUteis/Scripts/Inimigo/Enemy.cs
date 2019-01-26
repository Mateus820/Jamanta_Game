using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private float speed;	
	[SerializeField] private Rigidbody2D rb;

	void Start () {

	speed = 1;	
    rb = GetComponent<Rigidbody2D>();
	rb.velocity = new Vector2(speed, 0);
	}
	
	void Update () {

	if (transform.position.x >= 7.5)
	{
	transform.position  = new Vector2(transform.position.x-1, transform.position.y - 1);
		speed = -speed;
		rb.velocity = new Vector2(speed, 0);
	}
	else if (transform.position.x <= -7.5)
	{
		transform.position = new Vector2(transform.position.x + 1, transform.position.y - 1);
		speed = -speed;
		rb.velocity = new Vector2(speed, 0);
	}
}
}
