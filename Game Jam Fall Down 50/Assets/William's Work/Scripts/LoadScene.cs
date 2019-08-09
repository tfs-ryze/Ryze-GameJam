using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GotoNextScene()
    {
        if (SceneManager.GetActiveScene().name == "StartMenu")
        {
            // Go to 'PlayerSelection' Scene
            // - Scene must be loaded in Build Settings or it will not work
            // - Build Settings are located at Menu Bar: Edit->Build Settings
            // - Drag the Scenes in the project into 'Scenes in Build' space
            //Pause_Game.GameIsPaused = false;
            Time.timeScale = 1f;
            SceneManager.LoadScene("PlayerSelection");
        }
        else if (SceneManager.GetActiveScene().name == "PlayerSelection")
        {
            // Go to 'Level1' Scene
            // - Scene must be loaded in Build Settings or it will not work
            // - Build Settings are located at Menu Bar: Edit->Build Settings
            // - Drag the Scenes in the project into 'Scenes in Build' space
            //Pause_Game.GameIsPaused = false;
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level1");
        }
    }
}
