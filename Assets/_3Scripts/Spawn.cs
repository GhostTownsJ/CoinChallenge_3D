using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Spawner[] differentCoins; //tableaux des differentes pieces

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        int coinsDiferrent = Random.Range(0, 101); //nombre aléatoire entre 0 et 100
       
        for (int i = 0; i < differentCoins.Length; i++) 
        {
            if(coinsDiferrent > differentCoins[i].minProbabilityRange && coinsDiferrent< differentCoins[i].maxProbabilityRange) //si le nombre aléatoire est + grand que le game object associé par rapport a ses 2 int ou/et si et seulement si il est plus petit alors 
            {
                Instantiate(differentCoins[i].spawnObject, transform.position, transform.rotation, transform.parent); //un clone apparait du bon game object associer par rapport au range mis dans les 2 int min et max
                break;
            }
        }
    }
    [System.Serializable]
    public class Spawner //fonction public de spawn de coin
    {
        public GameObject spawnObject; //game object de pieces
        public int minProbabilityRange = 0; //int minimum d'apparitions
        public int maxProbabilityRange = 0; //int maximum 
    }
}
