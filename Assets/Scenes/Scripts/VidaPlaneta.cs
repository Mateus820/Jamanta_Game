using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Sprite[] vida;
	[SerializeField] private Image vidaIcones;

    // Start is called before the first frame update
    void Start()
    {
        Hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        MudarImagem();
    }

   void OnCollisionEnter2D(Collision2D other) {

       if(other.gameObject.CompareTag("TiroInimigo"))
       Hp --;

    }

    void MudarImagem(){

        if (Hp == 0){
            vidaIcones.sprite = vida[0];
        }
        else if (Hp == 1){
            vidaIcones.sprite = vida[1];
        }
        else if (Hp == 2){
            vidaIcones.sprite = vida[2];
        }
        else if (Hp == 3){
            vidaIcones.sprite = vida[3];
        }
    }
}
