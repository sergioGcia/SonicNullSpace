using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguir : MonoBehaviour {


	public Transform personaje;
	public float espacio = 3.7f;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (personaje.position.x+espacio, transform.position.y, transform.position.z);
	}
}
