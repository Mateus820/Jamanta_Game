using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;
    public GameObject pl;
    public PlayerCode player;
    public Rigidbody2D playerRb;

    void OnEnable() {
        pl = GameObject.FindGameObjectWithTag("Player");
        playerRb = pl.GetComponent<Rigidbody2D>();
        player = pl.GetComponent<PlayerCode>();    
    }

    public static Singleton GetInstance{
        get{
            if(instance == null)
                instance = GameObject.FindObjectOfType<Singleton>();

            return instance;
        }
    }
}
