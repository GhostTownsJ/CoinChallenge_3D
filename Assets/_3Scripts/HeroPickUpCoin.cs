using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroPickUpCoin : MonoBehaviour
{
    public AudioSource collectSound; //audio quand le hero prend la piece
    public Text score; //ui du score
    int collidedCoinValue; //detient la valeur de la piece quand le hero entre en collision avec
    public static int ScoreAmount; //montant du score

    void Start()
    {
        ScoreAmount = 0;
    }

    void Update()
    {
        score.text = "SCORE: " + ScoreAmount; //UI + montant du score se met a jour a chaque piece en +
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            collectSound.Play(); //audio se lance quand le hero prend la piece
            collidedCoinValue = other.gameObject.GetComponent<ValueCoins>().coinValue; //quand le hero entre en collision avec la piece on va chercher sa valeur dans le script ValueCoins
            ScoreAmount += collidedCoinValue; //le score est augmenter par la valeur piece
            Destroy(other.gameObject); //on detruit la piece quand le hero entre en collision avec 
        }
    }
}

