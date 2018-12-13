using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EfeitoCam : MonoBehaviour {

	// Use this for initialization
	public GameObject Camera;
	private void OnTriggerEnter(Collider other) {
		Camera.gameObject.SetActive(true);
	}
}
