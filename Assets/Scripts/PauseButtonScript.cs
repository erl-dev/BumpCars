using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButtonScript : MonoBehaviour
{
    public GameObject pauseCanvas;
    public Button pauseButton;

    public void PauseClicked()
    {
        
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseCanvas.SetActive(true);
            pauseButton.interactable = false;
        }

        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }


    public void Resume()
    {
        Time.timeScale = 1f;
        pauseCanvas.SetActive(false);
        pauseButton.interactable = true;

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScriptP1.scoreP1 = 0;
        ScoreScriptP2.scoreP2 = 0;
        
    }
   
   
   
}
