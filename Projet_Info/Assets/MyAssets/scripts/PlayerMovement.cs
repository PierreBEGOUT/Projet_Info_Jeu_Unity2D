using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 0.10f;       //Vitesse de course
    public float thrust = 0.4f;              //Impulsion de saut
    private Rigidbody2D rb;           //physique du personnage
    public LayerMask collisionMask;   //Mask de collision avec les plateformes
    private bool onGround;            //Boolean de test


    void OnGround() //Permet de tester si le joueur est sur une plateforme
    {
        if (Physics2D.OverlapArea(transform.FindChild("A").position, transform.FindChild("B").position, collisionMask))
        {
            onGround = true;
        }
        else
            onGround = false;
    }
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        OnGround();
        Vector3 dp = new Vector3();                                     //Création d'un vecteur 3D
        Vector2 jp = new Vector2(0,500);
        if(Input.GetKey(KeyCode.LeftArrow))                             //Si on appuie sur la flèche de gauche
        {
            dp.x -= speed;                                              //La variable x du vecteur correspond à - notre vitesse
        }
        if(Input.GetKey(KeyCode.RightArrow))                            //Si on appuie sur la flèche de droite
        {
            dp.x += speed;                                              //La variable x du vecteur correspond à + notre vitesse
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && onGround == true)      //Si on appuie sur la flèche du haut et que le personnage est sur une plateforme
        {
            rb.AddForce(jp);                                            //La variable y du vecteur correspond à notre hauteur
        }
        transform.position += dp;                                       //On change la position du personnage par notre vecteur
	}
}
