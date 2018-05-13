using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonador : MonoBehaviour {

	public GameObject[] listaBloques;
	public float tiempoMin=1f;
	public float tiempoMax=2f;


	// Use this for initialization
	void Start () {		
		NotificationCenter.DefaultCenter().AddObserver(this, "IniciarRun");
	}

	void IniciarRun (Notification not){
		Clonar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Clonar () {
		Instantiate(listaBloques [Random.Range (0, listaBloques.Length)], transform.position, Quaternion.identity);
		Invoke ("Clonar", Random.Range (tiempoMin,tiempoMax));
	}
}
