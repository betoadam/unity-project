using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")){
			MataPlay();
		}
		
	}
	public void MataPlay(){
		StartCoroutine(DelayBeto());
	}
	IEnumerator DelayBeto()
    {
        	yield return new WaitForSeconds(1.0f);
			SceneManager.LoadScene("Final");
    }
}
