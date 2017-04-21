using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Campagne : MonoBehaviour {

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
		if (guy.text == "Desert") {
			SceneManager.LoadScene ("Niveau1");
			PlayerPrefs.SetInt ("nbmorts ", 0);
		}
		else if (guy.text == "Montagne"){
			SceneManager.LoadScene ("Niveau4");
			PlayerPrefs.SetInt ("nbmorts ", 0);
		}
		else if (guy.text == "Usine"){
			SceneManager.LoadScene ("Niveau 7");
			PlayerPrefs.SetInt ("nbmorts ", 0);
		}
		else
			SceneManager.LoadScene ("Menu");
	}
}

