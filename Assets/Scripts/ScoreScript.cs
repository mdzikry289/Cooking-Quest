using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour{

    public static ScoreScript instance;
    
    public static float scoreValue = 0.0f;
    Text score;
    public float countdown = 15.0f;

    void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start(){
        score = GetComponent<Text> ();
    }


    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

    // public void setScore()
    // {
    //     scoreValue = scoreValue + 50;
    // }

    // public void setFinalScore(int scoreValue, int sisaWaktu){

    //     scoreValue = scoreValue * sisaWaktu;

    // }

}
