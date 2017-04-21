using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {

	public GUIText guy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		guy.text = "Bravo !" +
			" Vous avez terminé avec : " + PlayerPrefs.GetInt("nbmorts ") +" morts";
	}
}
