using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //bool si le jeu est en pause ou non
    public GameObject pauseMenuUi; //mon panneau pause

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //si on appuie sur P alors le bool est a true 
        {
            if (GameIsPaused) //le menu pause est afficher
            {
                Resume(); 
            }
            else
            {
                Pause(); 
            }
        }
    }

    public void Resume() //si on appuie sur resum alors le panneau pause se desactive le chrono continue et bool a false
    {
        pauseMenuUi.SetActive(false);
        Chrono.timerIsActivate = true;
        GameIsPaused = false;
    }

    void Pause() //si le panneau pause est activé alors le chrono se stoppe et bool a true
    {
        pauseMenuUi.SetActive(true);
        Chrono.timerIsActivate = false; 
        GameIsPaused = true;
    }

    public void MenuStart()  //si on appuie sur menu on revient au debut avec le panneau start, controls, quit
    {
        SceneManager.LoadScene("_0Scene/Start");
    }

    public void QuitGame() //si on appuie sur quit alors on quitte le jeu
    {
        Debug.Log("quitting game"); 
        Application.Quit();
    }
}
