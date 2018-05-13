using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	public long puntuacion=0;
	public Text texto;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"GanarPuntos");
	}

	void GanarPuntos (Notification not){
		int puntosGanados = (int)not.data;
		puntuacion += puntosGanados;
		Debug.Log ("añadiendo: " + puntosGanados + " Total: " + puntuacion);
		texto.text = puntuacion.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
