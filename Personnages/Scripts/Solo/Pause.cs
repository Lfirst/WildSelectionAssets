using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public bool GameIsPaused = false;

	public GameObject PauseMenu;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused)
				Resume ();
			else
				Stop();
		}
	}

	public void Resume(){
		PauseMenu.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Stop()
	{
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
		PauseMenu.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void loadMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene (0);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

}
