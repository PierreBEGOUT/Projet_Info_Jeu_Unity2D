using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderScript : MonoBehaviour 
{
	public int timer;
	public Animator animator;
    public int scene;
	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>(); //récupère les animations et leur enchainement
        scene = SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Death")      //si on rencontre un obstacle avec le tag "Death"
        {
        	animator.Play("Death");    			 //on joue l'animation de mort
        	StartCoroutine(Decompte());
        }
    }

    IEnumerator Decompte()
    {
    	Debug.Log("Avant l'attente");
    	yield return new WaitForSeconds(1);
    	Debug.Log("Après l'attente");
    	SceneManager.LoadScene(scene);
    }
}
