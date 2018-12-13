using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float velocidade;
	private int pontos;
	public Text placar;
	public Text venceu;
	public Button reiniciar;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>(); 
		pontos = 0;	
		AtualizaPlacar();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate(){
	float forcaHorizontal = Input.GetAxis("Horizontal");
	float forcaVertical = Input.GetAxis("Vertical")	;
	Vector3 forca = new Vector3(forcaHorizontal, 0.0f, forcaVertical);
	rb.AddForce(forca * velocidade);
	}
	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Colecionavel")){
			other.gameObject.SetActive(false);
			pontos++;
			AtualizaPlacar();
		}
		if(pontos>=8){
			venceu.gameObject.SetActive(true);
			reiniciar.gameObject.SetActive(true);
		}
		
	}
	void AtualizaPlacar(){
		placar.text = "Pontos: " + pontos.ToString();
	}
}
