﻿using UnityEngine;
using System.Collections;

public class Cubycube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer>().material.color = Color.red; 
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}

	}
}
