using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	private bool isShooting;
	void Start () {
		isShooting = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Fire();
		}
		RaycastHit hit;
		Debug.DrawRay(bulletSpawn.transform.position, bulletSpawn.transform.forward, Color.yellow);
		if (Physics.Raycast(bulletSpawn.transform.position, bulletSpawn.transform.forward, out hit, 100)){
			if (hit.collider.name.Contains("zombie")){
				if(!isShooting)
					StartCoroutine("Dispara");
			}
		}	
	}

	
	IEnumerator Dispara(){
		isShooting = true;
		Fire();
		yield return new WaitForSeconds(1f);
		isShooting = false;
	}
	void Fire(){
		/* Tiro Antigo
		var bulletL = (GameObject)Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
		bulletL.GetComponent<Rigidbody>().velocity = bulletL.transform.forward * 10.0f;
		Destroy(bulletL,3.0f);*/
		GameObject bullet = Instantiate(Resources.Load("bullet",typeof(GameObject))) as GameObject;
		bullet.transform.position = bulletSpawn.transform.position;
		bullet.transform.rotation = bulletSpawn.transform.rotation;

		Rigidbody rb = bullet.GetComponent<Rigidbody>();
		rb.AddForce(bulletSpawn.transform.forward * 500f);
		GetComponent<AudioSource>().Play();
		GetComponent<Animation>().Play();
		
		Destroy(bullet,3);
		
	}
}
