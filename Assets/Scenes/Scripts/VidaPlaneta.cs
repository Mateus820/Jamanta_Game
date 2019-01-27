using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlaneta : MonoBehaviour
{
     [SerializeField] public int Hp;
    public int hp {
        get {
            return this.hp;
        }
        set {
            this.hp = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
