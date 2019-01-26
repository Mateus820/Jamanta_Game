using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela1 : MonoBehaviour {

	[SerializeField] private GameObject tela1;
	void Start () {
		Invoke("Desativar", 3f);
	}
	
	void Desativar(){
		gameObject.SetActive(false);
	}
}
