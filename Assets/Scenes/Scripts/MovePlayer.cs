using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 move;
    [SerializeField] private Pool poolManager;

    [SerializeField] private float cd;

    [SerializeField] private bool canShoot; 
    
    void Start()
    {
        move = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
         canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");

         if (Input.GetButtonDown("Fire1"))
        {
            poolManager.GetObjectPooled(transform.position);
        }
    }

    IEnumerator CoolDown(){

        canShoot = false;
        yield return new WaitForSeconds(cd);
        canShoot = true;

    }

    void FixedUpdate() {
        rb.velocity = move;
    }
}
