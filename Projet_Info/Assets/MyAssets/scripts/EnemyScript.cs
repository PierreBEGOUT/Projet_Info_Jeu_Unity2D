using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Comportement générique pour les méchants

public class EnemyScript : MonoBehaviour
{
  private WeaponScript[] weapons;

  void Awake()
  {
    // Récupération de toutes les armes de l'ennemi
    weapons = GetComponentsInChildren<WeaponScript>();
  }

  void Update()
  {
    foreach (WeaponScript weapon in weapons)
    {
      // On fait tirer toutes les armes automatiquement
      if (weapon != null && weapon.CanAttack)
      {
        weapon.Attack(true);
      }
    }
  }
}
