using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Creates a class variable to keep track of 'GameManager' instance
    static GameManager _instance = null;

    public GameObject playerPrefab;

    // Use this for initialization
    void Start ()
    {
        if (instance)
            // 'GameManager' already exists, delete copy
            Destroy(gameObject);
        else
        {
            // 'GameManager' does not exist so assign a reference to it
            instance = this;

            // Do not destroy 'GameManager' on Scene change
            DontDestroyOnLoad(this);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public static GameManager instance
    {
        get { return _instance; }   // can also use just 'get;'
        set { _instance = value; }  // can also use just 'set;'
    }

    // Called when 'Character' is spawned
    public void SpawnPlayer(int spawnLocation)
    {
        // Requires spawnPoint to be named (SceneName)_(number)
        // - Level1_0
        string spawnPointName = SceneManager.GetActiveScene().name
            + "_" + spawnLocation;

        // Find location to spawn 'Character' at
        Transform spawnPointTransform = GameObject.Find(spawnPointName).GetComponent<Transform>();


        // Check if 'playerPrefab' and 'spawnPointTransform' exist
        if (playerPrefab && spawnPointTransform)
        {
            // Instantiate (Create) 'Character' GameObject

            GameObject Player_spawn = Instantiate(playerPrefab, spawnPointTransform.position, spawnPointTransform.rotation);
        }
        else
            Debug.LogError("Missing Player Prefab or SpawnPoint");
    }
    
    public void GotoMainMenu()
    {
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("StartMenu");
        }
    }

    public void TryAgain()
    {
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level1");
        }
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
