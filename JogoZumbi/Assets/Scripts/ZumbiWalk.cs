using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZumbiWalk : MonoBehaviour {

	private Transform destino;
	private NavMeshAgent agente;
	void Start () {
		destino = Camera.main.transform;
		agente = GetComponent<NavMeshAgent>();
		agente.destination = destino.position;
		GetComponent<Animation>().Play("walk");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		GetComponent<SphereCollider>().enabled = false;
		Destroy(other.gameObject);
		agente.destination = gameObject.transform.position;
		GetComponent<Animation>().Stop();
		GetComponent<Animation>().Play("back_fall");
		Destroy(gameObject,6);
		GameObject zombie = Instantiate(Resources.Load("zombie", typeof(GameObject))) as GameObject;
		float randomX = UnityEngine.Random.Range(-12f,12f);	
		float randomZ = UnityEngine.Random.Range(-12f,12f);

		

		while(Vector3.Distance(zombie.transform.position, destino.position)<= 3){
			randomX = UnityEngine.Random.Range(-12f,12f);	
			randomZ = UnityEngine.Random.Range(-12f,12f);
			zombie.transform.position = new Vector3(randomX, 0.1f, randomZ);
		}
	}
}
