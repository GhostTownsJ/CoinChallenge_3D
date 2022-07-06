using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHero : MonoBehaviour
{
    //variables pour tout les mouvement et vitesse
    public float moveSpeed;
    public float walkSpeed = 5f;
    public float runSpeed = 9f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;

    //Vector3 puisque jeu en 3d 
    private Vector3 direction = Vector3.zero;

    //on recupère le character controller et l'animator du perso
    CharacterController heroController;
    Animator heroAnim; 

    //fonction appeler juste avant la fonction start
    private void Awake()
    {
        heroAnim = GetComponent<Animator>();
    }

    void Start()
    {
        heroController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (heroController.isGrounded) //si le heros touche le sol alors
        {
            direction = new Vector3(0, 0, Input.GetAxis("Vertical")); //si on appuye sur z le perso avance
            direction = transform.TransformDirection(direction);
            direction *= moveSpeed;

            if (Input.GetKey(KeyCode.Space)) //si on appuie sur espace le perso saute
            {
                direction.y = jumpSpeed;
            }

            else if (!Input.GetKey(KeyCode.LeftShift)) //si on appuie pas sur left shift le perso arrete de courir et marche
            {
                moveSpeed = walkSpeed;
                heroAnim.SetFloat("isWalking", Input.GetAxis("Vertical"));
                heroAnim.SetBool("isRunningUpThatHill", false);

            }
            else if (Input.GetKey(KeyCode.LeftShift)) //si on appuie sur left shift le perso cours
            {
                Debug.Log("Maj is press"); 
                moveSpeed = runSpeed;
                heroAnim.SetBool("isRunningUpThatHill", true);
            }
        }

        direction.y -= gravity *Time.deltaTime;
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * 100);
        heroController.Move(direction * Time.deltaTime);
    }
}
