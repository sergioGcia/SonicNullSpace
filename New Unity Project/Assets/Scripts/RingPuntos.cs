using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingPuntos : MonoBehaviour {

	public int puntos;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Ring") {
			Destroy (obj.gameObject);
			NotificationCenter.DefaultCenter ().PostNotification (this, "GanarPuntos", puntos);
			audio.Play();﻿
		}
	}
}
