using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCleared : MonoBehaviour {

    int levelPassed, level, sceneIndex;
    public float countdown = 15.0f;
    public Text score;

    void Start(){
        sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void onNextLevelClicked(int level){
        SceneManager.LoadScene(level);
        PlayerPrefs.SetInt("LevelPassed", 1);
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1f;
    }

    public void onNextLevel3Clicked(int level){
        SceneManager.LoadScene(level);
        PlayerPrefs.SetInt("LevelPassed", 2);
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1f;
    }

    public void onMainMenu1Clicked(){
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.SetInt("LevelPassed", 1);
        Time.timeScale = 1f;
        ScoreScript.scoreValue = 0;
    }

    public void onMainMenu2Clicked(){
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.SetInt("LevelPassed", 2);
        Time.timeScale = 1f;
        ScoreScript.scoreValue = 0;
    }

    public void mainMenuTutorial(){
        SceneManager.LoadScene("MainMenu");
    }

    public void onNextLevelTutorialClicked(){
        SceneManager.LoadScene("Level 1");
    }
}
