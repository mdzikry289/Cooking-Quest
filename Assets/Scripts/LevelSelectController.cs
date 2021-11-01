using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelectController : MonoBehaviour{
    public Button level02Button, level03Button;
    public GameObject levelSelectPanel, resetConfirmationPanel;
    int levelPassed, sceneIndex;
    public GameObject tutorialPanel;
    

    //initialization
    void Start(){
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03Button.interactable = false;

        sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        switch (levelPassed) {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    public void levelToLoad(int level){
        SceneManager.LoadScene (level);
    }

    public void resetPlayerPrefs(){
        level02Button.interactable = false;
        level03Button.interactable = false;
        // PlayerPrefs.DeleteAll();
    }

    public void resetConfirmation(){
        resetConfirmationPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
    }

    public void tutorialButton(){
        SceneManager.LoadScene("Tutorial");
    }

    public void YesButton(){
        levelSelectPanel.SetActive(true);
        resetConfirmationPanel.SetActive(false);
        resetPlayerPrefs();
    }

    public void NoButton(){
        levelSelectPanel.SetActive(true);
        resetConfirmationPanel.SetActive(false);
    }
}
