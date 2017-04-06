using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
    // Déplace l'objet
    // 1 - Designer variables
    // Vitesse de déplacement
    public Vector2 speed = new Vector2(10, 10);
    // Direction
    public Vector2 direction = new Vector2(1, 0);

    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // 2 - Calcul du mouvement
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }

    void FixedUpdate()
    {
        // 5 - Déplacement
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
