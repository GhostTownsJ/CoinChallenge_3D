using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //variable pour ratation de piece sur vector3 et vitesse
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime); //rotation fois vitesse fois chaque frame
    }
}
