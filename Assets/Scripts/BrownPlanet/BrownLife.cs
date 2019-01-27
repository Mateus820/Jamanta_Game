using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrownLife : MonoBehaviour
{
    public int hp; 
    public Sprite[] health;
	[SerializeField] private Image lifeIcons;
    [SerializeField] private GameObject gameover;

    void Start()
    {
        hp = 3;
        ChangeHealth();

        lifeIcons.enabled = false;
    }

    void Update()
    {
        if(hp <= 0) {
            hp = 0;
            gameObject.SetActive(true);
        }
        else if(hp > 3) hp = 3;

        ChangeHealth();
    }

    public void Img(){
        lifeIcons.enabled = !lifeIcons.enabled;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("EnemyShot"))
        {    
            hp--;
            Destroy(other.gameObject);
        }
    }

    void ChangeHealth(){
        lifeIcons.sprite = health[hp];
    }
}
