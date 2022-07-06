using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text scoreEnd; //texte de mon score final

    private void Start()
    {
        scoreEnd.text = "SCORE: " + HeroPickUpCoin.ScoreAmount.ToString(); //je vais chercher le score dans le script heropickupcoin pour l'afficher a la fin
    }
}
