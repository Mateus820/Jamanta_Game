using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brotamento : MonoBehaviour
{
    public GameObject target;
    public float distance;

    [SerializeField] private float tempo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, tempo);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        Instantiate(target, transform.position, Quaternion.identity);
    }
}
