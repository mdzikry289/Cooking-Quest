using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    int level;

    public void onRestartClicked(int level){
        SceneManager.LoadScene(level);
        ScoreScript.scoreValue = 0;
    }

    public void onMainMenuClicked(){
        SceneManager.LoadScene("MainMenu");
        ScoreScript.scoreValue = 0;
    }
}
