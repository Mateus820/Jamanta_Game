using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela2 : MonoBehaviour {

	[SerializeField] private string nomeCena;
	
	void Start () {
		Invoke("MudarCena", 6f);
	}
	
	void MudarCena(){
		SceneManager.LoadScene(nomeCena);
	}
}
