﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;


/// Crée des projectiles

public class WeaponScript : MonoBehaviour
{
  //--------------------------------
  // 1 - Designer variables
  //--------------------------------

  
  /// Prefab du projectile
  
  public Transform shotPrefab;

  
  /// Temps de rechargement entre deux tirs
  
  public float shootingRate = 0.25f;

  //--------------------------------
  // 2 - Rechargement
  //--------------------------------

  private float shootCooldown;

  void Start()
  {
    shootCooldown = 0f;
  }

  void Update()
  {
    if (shootCooldown > 0)
    {
      shootCooldown -= Time.deltaTime;
    }
  }

  //--------------------------------
  // 3 - Tirer depuis un autre script
  //--------------------------------

  
  /// Création d'un projectile si possible
  
  public void Attack(bool isEnemy)
  {
    if (CanAttack)
    {
      shootCooldown = shootingRate;

      // Création d'un objet copie du prefab
      var shotTransform = Instantiate(shotPrefab) as Transform;

      // Position
      shotTransform.position = transform.position;

      // Propriétés du script
      ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
      if (shot != null)
      {
        shot.isEnemyShot = isEnemy;
      }

      // On saisit la direction pour le mouvement
      MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
      if (move != null)
      {
        move.direction = this.transform.right; // ici la droite sera le devant de notre objet
      }
    }
  }

  
  /// L'arme est chargée ?
  
  public bool CanAttack
  {
    get
    {
      return shootCooldown <= 0f;
    }
  }
}