using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public GameObject player;
	public static bool GameIsPaused = true;
	public GameObject pauseMenuUi;
	public GameObject pauseMenuUiInicio;
	// Update is called once per frame
	void Start() {
		Time.timeScale = 0.0f;	
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if (GameIsPaused){
				Resume();		
			}else{
				Pause();
			}
		}
	}
	public void Resume(){
		pauseMenuUi.SetActive(false);
		Time.timeScale = 1.0f;
		GameIsPaused = false;	
	}
	void Pause(){
		pauseMenuUi.SetActive(true);
		Time.timeScale = 0.0f;
		GameIsPaused = true;
	}
	public void RestartGame(){
		GameIsPaused = false;
		Time.timeScale = 1.0f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void LoadMenu(){
		GameIsPaused = false;
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("Menu");
	}
	public void ResumeInicio(){
		pauseMenuUiInicio.SetActive(false);
		Time.timeScale = 1.0f;
		GameIsPaused = false;	
	}
}
