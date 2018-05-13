using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSonic : MonoBehaviour {

	public float FuerzaSalto = 100f;
	public bool tocaSuelo = true;
	public Transform ComprobadorSuelo;
	private float radio = 0.01f;
	public LayerMask mascaraSuelo;
	private Animator animacion;
	private bool correr = false;
	public float vel = 2f;
	public int puntos = 10;
	public AudioSource audio;

	void Awake(){
		animacion = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate(){
		if (correr) { // si el personaje esta corriendo se le añade la velocidad
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (vel, GetComponent<Rigidbody2D> ().velocity.y);
			NotificationCenter.DefaultCenter ().PostNotification (this, "GanarPuntos", puntos);
		} //añadimos el movimiento en el eje x a la variable de la animacion
		animacion.SetFloat ("MovimientoX", GetComponent<Rigidbody2D>().velocity.x);
		//comprobamos si toca el suelo para poder saltar y hacemos lo mismompara que cambie la variable para la animacion
		tocaSuelo = Physics2D.OverlapCircle (ComprobadorSuelo.position, radio, mascaraSuelo);
		animacion.SetBool ("EnSuelo", tocaSuelo);
		transform.rotation = Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {
		//si toca la pantalla al empezar el juego corre y si ya esta corriendo, salta
		if (Input.GetMouseButtonDown (0)) {
			if (correr) {
				if (tocaSuelo) {
					GetComponent<Rigidbody2D>().AddForce(new Vector2(0,FuerzaSalto));
					audio.Play();﻿
				}
			} else {
				correr = true;
				//se envia la notificacion al clonador de suelos
				NotificationCenter.DefaultCenter ().PostNotification (this, "IniciarRun");
			}
		}

	}
}
