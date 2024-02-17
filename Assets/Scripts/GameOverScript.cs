using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverMenu;
    private TimerScript timerScript;
    public TMP_Text winnerText;

    void Update()
    {

        // Find the TimerScript component in the scene
        timerScript = FindObjectOfType<TimerScript>();
        
        // Example of using the remaining time value
        float remainingTime = timerScript.GetRemainingTime();
        
        if (remainingTime == 0 ){
            Winner();
            gameOverMenu.SetActive(true);
            Time.timeScale = 0;
        }
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

    private void Winner()
    {
        int scoreP1 = ScoreScriptP1.scoreP1;
        int scoreP2 = ScoreScriptP2.scoreP2;

        if (scoreP1 > scoreP2){
            winnerText.text = "PLAYER 1 IS THE WINNER!!!";
        } else if (scoreP2 > scoreP1){
            winnerText.text = "PLAYER 2 IS THE WINNER!!!";
        } else if (scoreP2 == scoreP1){
            winnerText.text = "IT'S A TIE GAME!!!";
        }
    }


}
