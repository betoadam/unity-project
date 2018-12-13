using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GanhaCorrida : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")){
				GanhaPlay();
		}
		if(other.gameObject.CompareTag("Inimigo")){
				MataPlay();
		}
	}
	public void GanhaPlay(){
		StartCoroutine(DelayBetoGanha());
	}
	IEnumerator DelayBetoGanha()
    {
        	yield return new WaitForSeconds(1.0f);
			SceneManager.LoadScene("Ganhou");
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

