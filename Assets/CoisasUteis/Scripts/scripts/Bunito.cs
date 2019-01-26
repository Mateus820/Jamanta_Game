using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bunito : MonoBehaviour
{
     [SerializeField] private Text txt;
    public int score;
    public int Score {get;set;}
    private int quantidadeColidido = 0;
    public int QuantidadeColidido {
        get { 
                return this.quantidadeColidido;
        }   
        set {
                this.quantidadeColidido = value;
        }
    }
    void Update()
    {
         txt.text = "Meteoros: " + score;
         
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("coisa"))
        {
            Destroy(coll.gameObject);
             quantidadeColidido++;   
            
        }

        else if (coll.gameObject.CompareTag("outracoisa"))
        {
            Destroy(coll.gameObject);
           
        }

    }
}