using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCenas : MonoBehaviour {

	public Player player;
	// Update is called once per frame
	void Update () {
		if (player.Hp <= 0)
		{
			Invoke("MudarCena", 0.2f);
		}
	}

	void MudarCena(){
        SceneManager.LoadScene("Derrota");
	  }
}
