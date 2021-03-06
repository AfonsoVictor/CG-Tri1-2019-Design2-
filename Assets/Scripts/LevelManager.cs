﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance = null;

    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);
    [SerializeField]
    private Transform Tape = null;

    public UIComponents uiComponents;

    SceneData sceneData = new SceneData();

    void Awake () {
        Assert.IsNotNull(Tape);
        if (instance == null) {
            instance = this;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DispayHudData();
    }
    public void IncrementCoinCount(){
        sceneData.coinCount = sceneData.coinCount + 1;
    }
    void DispayHudData(){
        uiComponents.hud. txtCoinCount.text = "x " + sceneData.coinCount;
    }
    public void SetTapeSpeed(float value) {
        TapeSpeed = new Vector3(value, TapeSpeed.y, TapeSpeed.z);
    }
    public void ShowLevelCompletePanel() {
        uiComponents.levelCompletePanel.LCPanel.SetActive(true);
        uiComponents.levelCompletePanel.txtScore.text = "" + sceneData.coinCount;
    }
    public void ShowGameOverPanel() {
        uiComponents.gameOverPanel.GOPanel.SetActive(true);
        uiComponents.gameOverPanel.txtScore.text = "" + sceneData.coinCount;
    }
}
