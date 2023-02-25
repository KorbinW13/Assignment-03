using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool gameIsPaused = false;
    public GameObject DisableScript;
    public GameObject pauseTextObject;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        DisableScript.GetComponent<Spawner>().enabled = false;
        pauseTextObject.SetActive(true);
        gameIsPaused= true;
    }
    void ResumeGame()
    {
        pauseTextObject.SetActive(false);
        DisableScript.GetComponent<Spawner>().enabled = true;
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void GiveUp()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
