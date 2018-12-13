using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarHelice : MonoBehaviour {
	public GameObject helice;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		helice.gameObject.transform.Rotate(0.0f,1.0f,0.0f);	
	}
}
