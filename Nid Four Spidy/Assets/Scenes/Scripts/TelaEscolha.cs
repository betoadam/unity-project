using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaEscolha : MonoBehaviour {
	public Camera cameraCarro;
	public Camera cameraCena;
	private Button inicia;
	public GameObject painel;
	// Use this for initialization
	public void IniciaGame(){
		painel.gameObject.SetActive(false);
		cameraCena.gameObject.SetActive(false);
		cameraCarro.gameObject.SetActive(true);
	}
}
