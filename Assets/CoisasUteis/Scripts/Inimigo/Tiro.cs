using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {

	public Player player;
	void Start() {
		player = GameManager.Game.player;	
	}
	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.CompareTag("Player"))
		{
			player.Hp--;
			print("?");
			this.gameObject.SetActive(false);
		}
		else if (coll.gameObject.CompareTag("Parede"))
		{
        	this.gameObject.SetActive(false);
		}
	}

	void OnDisable() {
		
		Invoke("Destruir", 3f);
	}

	void Destruir(){
		Destroy(this.gameObject);
	}
}
