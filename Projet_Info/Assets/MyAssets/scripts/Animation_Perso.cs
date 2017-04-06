using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animation_Perso : MonoBehaviour 
{
    public Animator animator;
    public Transform trans;
    private Rigidbody2D rb;
    public LayerMask collisionMask;
    private bool onGround;
    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
        trans = GetComponent<Transform>();
    }

    void OnGround()  //Permet de voir si le personnage à les pieds sur la plateforme
    {
        if (Physics2D.OverlapArea(transform.FindChild("A").position, transform.FindChild("B").position, collisionMask))
        {
            onGround = true;
        }
        else
            onGround = false;
    }

    // Update is called once per frame
    void Update ()
    {
    	OnGround();
        if (Input.GetKey(KeyCode.LeftArrow)&&(onGround==true))          //Si on est sur le sol et que l'on appuie sur la flèche de gauche
        {
            trans.eulerAngles = new Vector3 (0, -180, 0);				//On retourne le personnage vers la gauche
            animator.SetInteger("Animation", 2);						//On joue l'animation de course
        }
        else if (Input.GetKey(KeyCode.RightArrow)&&(onGround==true))    //Si on est sur le sol et que l'on appuie sur la flèche de droite
        {
        	trans.eulerAngles = new Vector3 (0, 0, 0);					//On retourne le personnage vers la droite
            animator.SetInteger("Animation", 2);						//On joue l'animation de course
        }
        else if (Input.GetKey(KeyCode.UpArrow))					//Si on appuie sur la flèche du haut
        {
            animator.SetInteger("Animation", 1);						//On joue l'animation de saut
        }
        else if((Input.GetKey(KeyCode.UpArrow))&&Input.GetKey(KeyCode.RightArrow))
        {
        	animator.SetInteger("Animation", 1);
        }
        else
            animator.SetInteger("Animation", 0);						//Sinon on joue l'animation de respiration
    }

}
