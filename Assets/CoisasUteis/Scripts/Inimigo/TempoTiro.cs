using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoTiro : MonoBehaviour {

	[SerializeField] private GameObject bala;

	[SerializeField] private float time;

	[SerializeField] private float firstTime;
	// Use this for initialization
	void Start () {
		 InvokeRepeating("Tiro", firstTime, time);
	}
	
	void Tiro(){
		Instantiate(bala, transform.position, Quaternion.identity);
	}
}
