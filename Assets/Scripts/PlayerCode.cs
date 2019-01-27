using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private bool cutscene; //Remover serialize depois...

    private Vector2 keyInput;

    void Start() {
        cutscene = false;    
    }

    void Update()
    {
        keyInput.x = Input.GetAxisRaw("Horizontal");
        keyInput.y = Input.GetAxisRaw("Vertical");

        /*if (Input.GetButtonDown("Space")){
            poolManager.GetObjectPooled(transform.position);
        }*/
    }

    void FixedUpdate() {
        if(cutscene) return;
        rb.velocity = new Vector2(keyInput.x * speed, keyInput.y * speed);
    }

    public void CutSceneMode(){
        cutscene = !cutscene;
        
        //Actions:
        rb.bodyType = RigidbodyType2D.Static;
    }
}
