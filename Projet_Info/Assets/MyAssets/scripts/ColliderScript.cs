using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ColliderScript : MonoBehaviour 
{
	public int timer;
	public Animator animator;
    public int scene;
    public int nbmorts=0;
    public GUIText guy;
	private int cpt;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>(); //récupère les animations et leur enchainement
        scene = SceneManager.GetActiveScene().buildIndex;
        if (PlayerPrefs.GetInt("nbmorts ") != 0)
        {
            // on verifie qu'il y a bien une sauvegarde 
            nbmorts = PlayerPrefs.GetInt("nbmorts "); //on récupère la sauvegarde
        }
		cpt = 0;
    }

        // Update is called once per frame
    void Update () 
	{
        if(Input.GetKeyDown(KeyCode.G))
        {
            nbmorts = 0;
            PlayerPrefs.SetInt("nbmorts ", nbmorts);
        }
        guy.text = "Nombre de morts : " + nbmorts;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Death") //si on rencontre un obstacle avec le tag "Death"
		{      
			animator.Play ("Death");    			 //on joue l'animation de mort
			cpt++;
			if (cpt == 1) 
			{
				StartCoroutine (Decompte ());
			}

		}
    }

    IEnumerator Decompte()
    {
		Debug.Log ("Avant attente");
    	yield return new WaitForSeconds(1);
		Debug.Log ("Après attente");
        SceneManager.LoadScene(scene);
		if (cpt > 1 || cpt == 1) 
		{
			cpt = 1;
			nbmorts = nbmorts + cpt;
			PlayerPrefs.SetInt ("nbmorts ", nbmorts); // fonction de sauvegarde unity
		}
    }
}
