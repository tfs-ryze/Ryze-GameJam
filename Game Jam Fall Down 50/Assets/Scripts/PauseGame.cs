using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    [SerializeField]
    private AudioClip Pause_SF;

    private AudioSource _Music;
    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //GameObject.Find("BackGroundMusic").GetComponent<AudioSource>().Play();
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        AudioScript.instance.PlayAudioClip(AudioScript.instance.PauseClip, 1);
        GameObject.Find("BackGroundMusic").GetComponent<AudioSource>().Pause();
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Debug.Log("Quit Game");
        SceneManager.LoadScene("StartMenu");
        
    }
}
