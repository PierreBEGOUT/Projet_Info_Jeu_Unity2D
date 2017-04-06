using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

	// 1 - Designer variables
    // Points de dégâts infligés
  	public int damage = 1;
	
	// Projectile ami ou ennemi ?
	public bool isEnemyShot = false;

	void Start()
	{
		// 2 - Destruction programmée
		Destroy(gameObject,20); //20 sec
	}
}
