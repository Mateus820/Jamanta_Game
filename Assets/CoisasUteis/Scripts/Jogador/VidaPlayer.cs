using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour {

	public Sprite[] vida;
	[SerializeField] private Image vidaIcones;
	public Player player;

	void Update () {
		MudarImagem();
	}

	void MudarImagem(){
		if (player.Hp == 0){
			vidaIcones.sprite = vida[0];
		}
		else if(player.Hp == 1){
			vidaIcones.sprite = vida[1];
		}
		else if(player.Hp == 2){
			vidaIcones.sprite = vida[2];
		}
		else if(player.Hp == 3){
			vidaIcones.sprite = vida[3];
		}
	}
}
