using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour {

	// Use this for initialization
	public void ReinciarCena(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
