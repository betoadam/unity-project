using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatePolicia : MonoBehaviour {

	// Use this for initialization
	private void OnCollisionEnter(Collision other) {
		Debug.Log("PASSEI COLISAO");
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
			SceneManager.LoadScene("GameOver");
    }
}
