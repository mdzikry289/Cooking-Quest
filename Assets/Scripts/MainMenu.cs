using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject levelSelectPanel;
    public GameObject aboutPanel;
    public GameObject settingsPanel;
    public GameObject howtoplayPanel;
    public GameObject bukuResepPanel;
    public GameObject exitConfirmationPanel;
    public GameObject panelSateMaranggi;
    public GameObject panelNasiTutug;
    public GameObject panelKaredok;
    public GameObject panelWelcome, panelWelcome2;
    public GameObject panelMainMenu;

    public void OnPlayButtonClicked(){
        levelSelectPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void onSettingsButtonClicked(){
        settingsPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void onAboutButtonClicked(){
        aboutPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void onHowToPlayButtonClicked(){
        howtoplayPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void onBukuResepClicked(){
        bukuResepPanel.SetActive(true);
        howtoplayPanel.SetActive(false);
    }

    public void onResepSateMaranggiClicked(){
        panelSateMaranggi.SetActive(true);
        bukuResepPanel.SetActive(false);
    }

    public void onResepNasiTutugClicked(){
        panelNasiTutug.SetActive(true);
        bukuResepPanel.SetActive(false);
    }

    public void onResepKaredokClicked(){
        panelKaredok.SetActive(true);
        bukuResepPanel.SetActive(false);
    }

    public void OnBackClicked(){
        levelSelectPanel.SetActive(false);
        howtoplayPanel.SetActive(false);
        aboutPanel.SetActive(false);
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
        bukuResepPanel.SetActive(false);
    }

    public void OnBackResepClicked(){
        bukuResepPanel.SetActive(true);
        panelSateMaranggi.SetActive(false);
        panelNasiTutug.SetActive(false);
        panelKaredok.SetActive(false);
    }

    public void OnExitYesButtonClicked(){
        #if UNITY_EDITOR
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        #endif
        Application.Quit();
    }

    public void OnOkClicked(){
        panelMainMenu.SetActive(true);
        panelWelcome.SetActive(false);
        panelWelcome2.SetActive(false);
    }

    public void nantiAjaButton(){
        panelMainMenu.SetActive(true);
        panelWelcome.SetActive(false);
    }

    public void OnExitConfirmation(){
        exitConfirmationPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void OnExitNoButtonClicked(){
        mainPanel.SetActive(true);
        exitConfirmationPanel.SetActive(false);
    }
}
