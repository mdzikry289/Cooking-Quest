using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BumbuinSate : MonoBehaviour
{
    public GameObject sate;
    public GameObject bumbuSate;
    public GameObject sateFinal;
    public GameObject currentPanel;
    public GameObject npcDialogClear;
    float initialTime = 0f;
    float countWaktu = 1f;
    float countdown = 31f;

    public bool selesai = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void cek(){
        for (int i = 0; i < 2; i++){
            if (transform.GetChild (i).GetComponent<Drag> ().on_place){
                selesai = true;
            } else {
                selesai = false;
                i = 2;
            }
        }
        if (selesai){
            sate.SetActive(false);
            bumbuSate.SetActive(false);
            sateFinal.SetActive(true);
            currentPanel.SetActive(false);
            npcDialogClear.SetActive(true);
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
        if(selesai){
            int sisawaktu = (int)countdown * 5;
            ScoreScript.scoreValue += sisawaktu;
        }
    }
}
