using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{

    [SerializeField] private string name;
    [SerializeField] private Image keyImage;
    [SerializeField] private bool canTalk; //Remover serializeField;
    [SerializeField] private BrownLife brLife;
    [SerializeField] private Spawner sp;
    private PlayerCode player;

    void Start()
    {
        canTalk = false;
        keyImage.enabled = false;
        player = Singleton.GetInstance.player;
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && canTalk){
            CutScene_01();
        }    
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
    #region CutScene
    
    void CutScene_01(){
        //Parar movimentação do player;
        player.CutSceneMode();
        //Executar fala;
        
        //Iniciar game;
        brLife.Img();
        sp.enabled = true;
    }

    #endregion

}
