using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bala : MonoBehaviour {

	[SerializeField] private float speed;
	[SerializeField] private Rigidbody2D rb;

	
	
	void Start(){
	
	}
	void FixedUpdate () {
		rb.velocity = Vector2.up * speed;
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.CompareTag("Inimigo")){
		Destroy(coll.gameObject);
		gameObject.SetActive(false);
        GameManager.Game.score.points++;
		}
		else if (coll.gameObject.CompareTag("Parede"))
        {
            gameObject.SetActive(false);
        }
	}
}
