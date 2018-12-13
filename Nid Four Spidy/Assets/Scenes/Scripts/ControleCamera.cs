using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour {

	// Use this for initialization
	public GameObject CameraFrente;
	public GameObject CameraRe;
	void Start () {
		CameraFrente.gameObject.SetActive(true);	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			CameraFrente.gameObject.SetActive(false);
			CameraRe.gameObject.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.S)){
			CameraRe.gameObject.SetActive(false);
			CameraFrente.gameObject.SetActive(true);
		}
		
		
	}
}
