using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MandarRecibirServer : MonoBehaviour {

	public string GETURL = "https://sonic-null-space.000webhostapp.com/Recibir.php";
	public string SENDURL = "https://sonic-null-space.000webhostapp.com/Enviar.php";
	public InputField TextoMandado;
	public Text TextoMostrado;

	// Use this for initialization
	public void Enviar () {
		StartCoroutine("Mandar");
	}
	
	// Update is called once per frame
	public void Recibir () {
		StartCoroutine("Leer");
	}

	private IEnumerator Mandar(){
		Debug.Log ("Entro en el servidor para escribir");
		string url = SENDURL + "?name=" + WWW.EscapeURL(TextoMandado.text);
		WWW enviar = new WWW (url);
		yield return enviar;
		Debug.Log (enviar.text);
	}
	private IEnumerator Leer(){
		Debug.Log ("Entro en el servidor para recibir");
		WWW leer = new WWW (GETURL);
		yield return leer;
		TextoMostrado.text=string.Concat(TextoMostrado.text+" ",leer.text);
		Debug.Log (leer.text);
	}
}
