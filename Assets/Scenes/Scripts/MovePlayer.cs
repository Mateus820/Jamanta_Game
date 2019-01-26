using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        move = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
    }
    
    void FixedUpdate() {
        rb.velocity = move;
    }
}
