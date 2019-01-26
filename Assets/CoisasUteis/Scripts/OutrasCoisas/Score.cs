using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	[SerializeField] private Text texto;
	public int points;
    public int Points {get;set;}

	void Start () {
		points = 0;
	}
	
	void Update () {
		texto.text = "" + points;
	}
}
