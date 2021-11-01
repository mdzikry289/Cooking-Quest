using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drag : MonoBehaviour {
    public GameObject detector;
    Vector3 pos_awal;
    public bool on_pos = false, on_place = false;

    // Start is called before the first frame update
    void Start()
    {
        pos_awal = transform.position;
        
    }

    void OnMouseDrag(){
        Vector3 pos_mouse = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        transform.position = new Vector3(pos_mouse.x, pos_mouse.y, -1f);
    }

    void OnMouseUp(){
        if(on_pos){
            transform.position = detector.transform.position;
            on_place = true;
        }
        else{
            transform.position = pos_awal;
            on_place = false;
            ScoreScript.scoreValue -= 25;
        }
    }

    void OnTriggerStay2D(Collider2D objek){
        if(objek.gameObject == detector){
            on_pos = true;
        }
    }

    void OnTriggerExit2D(Collider2D objek){
        if(objek.gameObject == detector){
            on_pos = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
