using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private float tempo;
    [SerializeField] private float tempoInicio;
    [SerializeField] private Transform[] points;

    void OnEnable()
    {
        InvokeRepeating("SpawnObject", tempoInicio, tempo);
    }

    void SpawnObject()
    {
        int random = Random.Range(0, points.Length);
        Instantiate(prefab, points[random].position, Quaternion.identity);
    }
}
