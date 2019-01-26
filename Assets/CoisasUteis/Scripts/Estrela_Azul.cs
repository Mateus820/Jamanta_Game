using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estrela_Azul : MonoBehaviour {

	[SerializeField] private string nomeCena;
	void Start() {
				
	}
	void OnTriggerEnter2D(Collider2D other) {
		
		GameManager.Game.blackScreen.Escurecer();
        Invoke("MudarCena", 0f);
	}

	void MudarCena() {
		SceneManager.LoadScene(nomeCena);
	}	

}
