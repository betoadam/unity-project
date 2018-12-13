using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndaHelicoptero : MonoBehaviour {
	public GameObject Helicoptero;
	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
 
		Vector3 movimento;
		movimento = (new Vector3(1.0f,0,0)*Time.deltaTime);
		Helicoptero.transform.position= movimento;
    }
	private void FixedUpdate() {
		//Helicoptero.transform.(Vector3. * Time.deltaTime*30, Space.World);
	}
    
    

}
