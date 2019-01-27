using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] Rigidbody2D rb;
    private Vector2 keyInput;

    void Start()
    {
       
    }

    void Update()
    {
        keyInput.x = Input.GetAxisRaw("Horizontal");
        keyInput.y = Input.GetAxisRaw("Vertical");

       
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(keyInput.x * speed, keyInput.y * speed);
    }
}
