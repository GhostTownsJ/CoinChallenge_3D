using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chrono : MonoBehaviour
{
    public float timer = 99; // public float de mon chrono
    public Text timerText; //UI
    public static bool timerIsActivate = true;

    void Start()
    {
        timerText = GetComponent<Text>(); //on va chercher l'UI text du temps
    }

    
    void Update()
    {
        if (timerIsActivate) //quand le chrono demarre
        {
            timer -= Time.deltaTime; //on fait une decrémentation chaque frame
            timerText.text = timer.ToString("f2"); // on affiche 2 chiffre après la virgule
            
            if (timer <= 0) //si le chrono va en dessous de 0 donc -0,01 par exemple 
            {
                timer = 0;
                timerText.text = timer.ToString("0.00"); // on affiche sur l'UI le chrono a 0 pile
                timerIsActivate = false; // on passe le bool a false car c'est finit
                SceneManager.LoadScene("_0Scene/EndScene"); //on load la scène suivante 
            }
        }
        
    }
}
