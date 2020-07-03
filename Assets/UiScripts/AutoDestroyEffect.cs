﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyEffect : MonoBehaviour {

    ParticleSystem particle;

	// Use this for initialization
	void Start () {
        particle = GetComponent<ParticleSystem>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (particle.isPlaying == false) Destroy(gameObject);
	}
}
