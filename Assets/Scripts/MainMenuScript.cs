using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject settingsUI;
    public GameObject modeSelectionUI;

    public void PlayGame ()
    {
        modeSelectionUI.SetActive(true);
        mainMenuUI.SetActive(false);       
    }

    public void SettingsClicked()
    {    
        settingsUI.SetActive(true);
     }

    public void SettingsClosed()
    {
        settingsUI.SetActive(false);

    }

    public void BackButtonClicked(){
        modeSelectionUI.SetActive(false);
        mainMenuUI.SetActive(true); 
    }

    public void PlayerVsPlayer(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame ()
    {
        Application.Quit();
    }
}
