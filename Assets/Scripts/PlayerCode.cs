using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Pool poolManager;


    private Vector2 keyInput;

    void Start()
    {
        
    }

    void Update()
    {
        keyInput.x = Input.GetAxisRaw("Horizontal");
        // keyInput.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Space")){
            poolManager.GetObjectPooled(transform.position);
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(keyInput.x * speed, keyInput.y * speed);
    }
}
