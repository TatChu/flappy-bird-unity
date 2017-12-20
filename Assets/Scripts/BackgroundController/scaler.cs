﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();

		Vector3 tempScale = transform.localScale;

		float height = sr.bounds.size.y;
		float width = sr.bounds.size.x;

		float worldHeight = Camera.main.orthographicSize * 2f;
		float worldWidth = worldHeight * Screen.width / Screen.height;

		tempScale.y = worldHeight / height;
		tempScale.x = worldWidth / width;

		transform.localScale = tempScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
