using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeOncom3 : MonoBehaviour
{
    public GameObject nasi;
    public GameObject oncom;
    public GameObject masako;
    public GameObject container1;
    public GameObject container2;
    public GameObject container3;
    public GameObject currentPanel;
    public GameObject npcDialogClear;
    public bool selesai = false;
    float initialTime = 0f;
    float countWaktu = 1f;
    float countdown = 31f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void cek(){
        for (int i = 0; i < 3; i++){
            if (transform.GetChild (i).GetComponent<Drag> ().on_place){
                selesai = true;
            } else {
                selesai = false;
                i = 3;
            }
        }
        if (selesai){
            nasi.SetActive(false);
            oncom.SetActive(false);
            masako.SetActive(false);
            container1.SetActive(false);
            container2.SetActive(false);
            container3.SetActive(false);
            currentPanel.SetActive(false);
            npcDialogClear.SetActive(true);
            // TimerSettings.instance.setScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!selesai){
            cek();
        }
        initialTime += countWaktu * Time.deltaTime;
        countdown -= countWaktu * Time.deltaTime;
        // Debug.Log((int)countdown);
        if(selesai){
            int sisawaktu = (int)countdown * 5;
            ScoreScript.scoreValue += sisawaktu;
        }
    }
}
