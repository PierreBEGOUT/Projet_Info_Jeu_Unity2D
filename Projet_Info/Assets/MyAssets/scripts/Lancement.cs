using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lancement : MonoBehaviour {

	public int scene;
	public GUIText guy;
	// Use this for initialization
	void Start () {
		scene = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseUp()
	{
		if (guy.text == "Quitter") {
			Application.Quit ();
			Debug.Log ("ça marche");
		}
		else if (guy.text == "Jouer"){
			SceneManager.LoadScene ("Niveau1");
			PlayerPrefs.SetInt ("nbmorts ", 0);
		}
		else
		{
			SceneManager.LoadScene (scene+1);
			PlayerPrefs.SetInt ("nbmorts ", 0);
		}
	}
}
