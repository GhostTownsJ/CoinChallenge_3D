using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueCoins : MonoBehaviour
{
    //Nom et valeur des pieces utilisé
    private string pirateCoinName;
    public int coinValue;

    
    void Start()
    {
        //switch pour chaque nom de piece une valeur differente
        pirateCoinName = name.Substring(0, 10);

        switch (pirateCoinName)
        {
            case "PirateCoin1":
                coinValue = 1;
                break;


            case "PirateCoin2":
                coinValue = 3;
                break;


            case "PirateCoin3":
                coinValue = 5;
                break;


            case "PirateCoin4":
                coinValue = 10;
                break;
        }
    }

}
