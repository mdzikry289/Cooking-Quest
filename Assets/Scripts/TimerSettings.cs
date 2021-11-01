using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSettings : MonoBehaviour
{
    public static TimerSettings instance;
    public Text TextTimer;
    public float Waktu = 30;
    public bool GameAktif = true;
    public GameObject CanvasKalah;
    public GameObject tabelMasakPanel, tabelMasakPanel2, tabelMasakPanel3;
    public GameObject bahanMasakPanel, bahanMasakPanel2;

    void Awake(){
        instance = this;
    }
    

    public void SetText(){
        //TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
        int Detik = Mathf.FloorToInt(Waktu % 60);

        TextTimer.text = Detik.ToString("00");
    }

    float s;

    // Update is called once per frame

    public void Update()
    {   
        if(GameAktif){
            s += Time.deltaTime;
            if(s >= 1){
                Waktu--;
                s = 0;
            }
        }

        
        if(GameAktif && Waktu <- 0){
            // Debug.Log("Game Kalah");
            
            CanvasKalah.SetActive(true);
            bahanMasakPanel.SetActive(false);
            tabelMasakPanel.SetActive(false);
            tabelMasakPanel2.SetActive(false);
            tabelMasakPanel3.SetActive(false);
            GameAktif = false;
        }

        SetText();
    }
}
