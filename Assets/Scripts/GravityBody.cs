using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GravityBody : MonoBehaviour
{   
    public Gravity planet;
    [SerializeField] private Rigidbody2D rb;

    void Awake() {
        planet = null;    
    }

    void FixedUpdate() {
        if(planet == null)
            return;

        planet.Attract(transform, rb);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "PlanetAtm"){
            planet = other.GetComponent<Gravity>();
        }    
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "PlanetAtm"){
            planet = null;
        }    
    }
}
