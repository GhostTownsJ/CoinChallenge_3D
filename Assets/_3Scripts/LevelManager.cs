using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void StartTheGame() //si on appuye sur start le jeu se lance sur la scene 1 et le chrono demarre
    {
        SceneManager.LoadScene("_0Scene/scene 1");
        Chrono.timerIsActivate = true;
    }

    public void QuitGame() //si on appuye sur la touche quit pour quitter le jeu on affiche dans la console quitting game et en build l'appli se ferme
    {
        Debug.Log("quitting game");
        Application.Quit();
    }
}