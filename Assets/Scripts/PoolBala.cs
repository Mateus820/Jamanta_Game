using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBala : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
         rb.velocity = Vector2.right * speed;
    }
     void OnCollisionEnter(Collision other) {

         gameObject.SetActive(false);
        
    }
}

