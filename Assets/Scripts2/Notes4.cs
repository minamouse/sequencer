﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<ChuckSubInstance>().RunCode(@"
			SinOsc foo => dac;
			1000 => foo.freq;
				100::ms => now;
		");
    }
}
