using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversaDebonia : MonoBehaviour {
public Datilografia datilografia;

	// Use this for initialization
	void Start () {
        DigitarDialogo("FalaComDebonia1");
	}
	
	// Update is called once per frame
	
    private void DigitarDialogo(string nomeArquivo)
    {
        datilografia.Digitando(nomeArquivo + ".txt");
    }
}
