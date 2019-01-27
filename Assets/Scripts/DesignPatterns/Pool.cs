using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] private GameObject pooledObject;
    [SerializeField] private int size;
    [SerializeField] private bool willGrow;
    private List<GameObject> pool;

    void Start()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < size; i++)
        Create();
    }
    
    private void Create(){
        pool.Add(Instantiate(pooledObject, parent: transform));
        pool[pool.Count -1].SetActive(false);
    }

    public GameObject GetObjectPooled(Vector3 position){
        
        for (int i = 0; i < pool.Count; i++)
            if(!pool[i].activeSelf){
                pool[i].transform.position = position;
                pool[i].SetActive(true);
                return pool[i];
            }
            if(willGrow){
                GameObject obj = (GameObject) Instantiate(pooledObject, parent: transform);
                pool.Add(obj);
                return obj;
            }
        return null;
    }
        
}
