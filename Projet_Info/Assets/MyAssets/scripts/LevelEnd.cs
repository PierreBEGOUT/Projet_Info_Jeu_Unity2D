using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour {

    public int timer; //utile pour attendre avant le prochain lvl
    public int scene;

    // Use this for initialization
    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex; //Récupère les infos de la scene actuelle
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FinNiveau")      //si on rencontre un obstacle avec le tag "FinNiveau"
        {
            StartCoroutine(Decompte()); //On lance le décompte
        }
    }

    IEnumerator Decompte()
    {
        Debug.Log("Avant l'attente");
        yield return new WaitForSeconds(1);
        Debug.Log("Après l'attente");
        SceneManager.LoadScene(scene+1); //On lance la scene suivante
    }
}