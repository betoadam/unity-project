using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueCamera : MonoBehaviour {

	private Vector3 espacamento;
	public GameObject Player;
	// Use this for initialization
	void Start () {
		espacamento = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = Player.transform.position + espacamento;
	}
}
