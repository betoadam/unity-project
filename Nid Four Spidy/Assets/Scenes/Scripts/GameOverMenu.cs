using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverMenu : MonoBehaviour {
public static bool GameIsPaused = false;
	// Use this for initialization
	public void LoadMenu(){
		GameIsPaused = false;
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("Menu");
	}
}
