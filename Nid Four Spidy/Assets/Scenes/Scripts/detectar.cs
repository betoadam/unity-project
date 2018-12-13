using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour {

	// Use this for initialization
	
		void OnCollisionEnter(Collision other)
	{
		Debug.Log(other.gameObject.name);	
	}

	private void OnTriggerEnter(Collider other) {
		Debug.Log(other.gameObject.name);
	}
}
