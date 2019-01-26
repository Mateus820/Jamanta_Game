using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

     private float timeLeft = 30.0f;
     private string proximaCena;

    public Bunito bunito;
    [SerializeField] private Text texto;
    public float TimeLeft{get;set;}

    void Update () {

        texto.text = "Tempo: " + Mathf.CeilToInt(timeLeft).ToString();
        timeLeft -= Time.deltaTime;
        if (bunito.QuantidadeColidido != 0)
        {
            GameOver();
        }
      
        else if (timeLeft <= 0 && bunito.QuantidadeColidido == 0)
        {   
            GameManager.Game.blackScreen.Escurecer();
            Invoke("Seila", 0.5f);  
        }
	}

    void GameOver()
    {
            mudarCena("IntroJogo2");
    
    }
    void mudarCena(string cena)
    {
        //cena1 = "Jogo do Buraco Negro"
        //cena2 = "Moca pt2"
        proximaCena = cena;
		GameManager.Game.blackScreen.Escurecer();
        Invoke("MudaCena", 0.1f);

    }

    private void MudaCena() {
        SceneManager.LoadScene(proximaCena);
    }
    void Seila()
    {       
            mudarCena("Moca pt2");
    }
}
