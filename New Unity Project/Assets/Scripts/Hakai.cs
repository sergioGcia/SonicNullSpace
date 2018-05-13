using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hakai : MonoBehaviour {
	public string INSERTURL = "https://sonic-null-space.000webhostapp.com/Insertar.php";
	public Text puntos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Player") {
			StartCoroutine("Mandar");

		} else {
			Destroy (obj.gameObject);
		}
	}

	private IEnumerator Mandar(){
		string url = INSERTURL + "?nombre=Unity&puntuacion="+puntos.text;
		WWW enviar = new WWW (url);
		yield return enviar;
	}
}
