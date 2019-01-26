﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollManager : MonoBehaviour {

	[SerializeField] private GameObject pooledObject;
	[SerializeField] private int size;
	private List<GameObject> pool;

	void Start () {
		pool = new List<GameObject>();
		for (int i = 0; i < size; i++){
			Create();
		}
	}

	public GameObject Spawn(Vector3 position){
		for (int i = 0; i < pool.Count; i++){
			if(!pool[i].activeSelf){
				pool[i].transform.position = position;
				pool[i].SetActive(true);
				return pool[i];
			}
		}
		return null;
	}
	
	private void Create(){
		pool.Add(Instantiate(pooledObject));
		pool[pool.Count - 1].SetActive(false);
	}
}