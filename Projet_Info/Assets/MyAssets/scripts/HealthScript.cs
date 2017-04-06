using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

	// Gestion des points de vie et des dégâts
	// Points de vie
	public int Hp = 1;

	//Ennemi ou joueur ?
	public bool isEnemy = true;

	void OnTriggerEnter2D(Collider2D collider)
	{
		//Est-ce un tir ?
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
		if(shot != null)
		{
			//tir allié
			if(shot.isEnemyShot != isEnemy)
			{
				Hp -= shot.damage;
				//destruction du prjectile
				//on détruit toujours le même gameObject associé
				//sinon c'est le script qui serait détruit avec "this"
				Destroy(shot.gameObject);

				if(Hp<=0)
				{
					//Destruction
					Destroy(gameObject);
				}
			}
		}
	}

}
