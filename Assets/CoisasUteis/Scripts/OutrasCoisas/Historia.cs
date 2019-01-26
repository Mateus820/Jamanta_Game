using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia : MonoBehaviour {

	[SerializeField] private GameObject texto1;
	[SerializeField] private GameObject texto2;
	[SerializeField] private GameObject texto3;
	[SerializeField] private GameObject espaço;

	[SerializeField] private GameObject botao;
	
	void Update(){
		if (Input.GetButtonDown("Fire1")){
			if(texto1.activeSelf)
			{
				texto1.SetActive(false);
				texto2.SetActive(true);	
			}
			else if (texto2.activeSelf)
			{
				texto2.SetActive(false);
				texto3.SetActive(true);	
				espaço.SetActive(false);
				botao.SetActive(true);
			}
		}
	}

}
