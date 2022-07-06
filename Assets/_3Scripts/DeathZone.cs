using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public Transform rpgHero; //variable de la position du hero 

    void Update()
    {
        if (rpgHero.position.y < -10) //si la position du heros passe en dessous de -10 alors
        {
            Debug.Log("Game Over !");
            SceneManager.LoadScene("_0Scene/GameOver"); //on load la scene game over
        }
    }
}
