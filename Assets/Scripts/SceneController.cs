using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public int val;

    public void SetValue(int number){
        //0 = Start;
        //1 = Continue;

        val = number;
    }

    public void ChangeScene(string sceneName){
        if(sceneName == "Game"){
            PlayerPrefs.SetInt("Mode", val);
        }
        SceneManager.LoadScene(sceneName);
    }

    public void GameOver(){
        //DataManager.instance.SaveGame();
        SceneManager.LoadScene("GameOver");
    }
}
