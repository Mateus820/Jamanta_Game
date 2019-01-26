using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour {

	public void TrocarCena(string cena){
        SceneManager.LoadScene(cena);
    }
}
