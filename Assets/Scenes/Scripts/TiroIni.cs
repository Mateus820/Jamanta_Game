using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroIni : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private ParticleSystem ps;

    void OnEnable() {
        
        rb.AddForce(new Vector2(0, -500));

        Invoke("TimeDestroy", 5f);
    }

    void TimeDestroy(){
        //ps.Play();
        Destroy(gameObject, 0.08f);
    }

    void OnMouseDown(){
        //ps.Play();
        Destroy(this.gameObject, 0.08f);
    }
}
