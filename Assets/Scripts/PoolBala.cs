﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBala : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    void FixedUpdate()
    {
         rb.velocity = Vector2.up * speed;
    }
     void OnCollisionEnter(Collision other) {

         if (other.gameObject.CompareTag("Chão")){
         this.gameObject.SetActive(false);
         print("bateu");
         }
    }
}

