using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{

    [SerializeField] private string name;
    [SerializeField] private Image keyImage;
    private bool canTalk;

    void Start()
    {
        canTalk = false;
        keyImage.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            canTalk = true;
            keyImage.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            canTalk = false;
            keyImage.enabled = false;
        }
    }

}
