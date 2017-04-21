using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonAction : MonoBehaviour {

	public Color couleurEntree = Color.white;
	public Color couleursortie = Color.black;
	public int tailleEntrer = 65;
	public int tailleSortie = 60;
	public GUIText guy;
		
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseEnter()
	{
		guy.color = couleurEntree;
		guy.fontSize = tailleEntrer;
	}

	public void OnMouseExit()
	{
		guy.color = couleursortie;
		guy.fontSize = tailleSortie;
	}
}
