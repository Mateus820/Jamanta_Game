using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolPlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Pool poolManager;

    private Rigidbody2D rb;
    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
