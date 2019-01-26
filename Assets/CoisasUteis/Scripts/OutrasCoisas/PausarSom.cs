using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausarSom : MonoBehaviour {

	// [SerializeField] private Image img;
	// [SerializeField] private Image img2;

	[SerializeField] private Button botao;
	public void PlayPause(){
		if(AudioListener.pause)
		{
			AudioListener.pause = false;
			// botao.image = img;
		}
		else
		{
			AudioListener.pause = true;
			// botao.image = img2;
		}
	}

	
	
}
