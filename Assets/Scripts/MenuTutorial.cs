using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTutorial : MonoBehaviour{

    public GameObject mainPanel;
    public GameObject pausePanel;
    public GameObject bahanMasakPanel;
    public GameObject confirmationPanel;
    public GameObject tabelMasakPanel;

    public void OnPauseButtonClicked(){
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnPlayButtonClicked(){
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void OnMainMenuButtonClicked(){
        confirmationPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void OnYesButtonClicked(){
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void OnNoButtonClicked(){
        pausePanel.SetActive(true);
        confirmationPanel.SetActive(false);
    }

    public void OnReloadButtonClicked(){
        SceneManager.LoadScene("Tutorial");
        Time.timeScale = 1f;
    }
}
