﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNotes : MonoBehaviour {
    public float Speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * Time.deltaTime * Speed);
	}
}
