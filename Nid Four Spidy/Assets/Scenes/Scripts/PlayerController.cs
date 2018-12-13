using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float velocidade;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate() {
		float forcaHorizontal = Input.GetAxis("Horizontal");
		float forcaVertical = Input.GetAxis("Vertical")	;
		Vector3 forca = new Vector3(forcaHorizontal, 0.0f, forcaVertical);	
		rb.AddForce(forca * velocidade);
	}
}
