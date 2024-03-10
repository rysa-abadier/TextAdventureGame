using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public GameObject[] Scenes;
    public GameObject[] Dialogue;
    public int ActiveScene;
    public int ActiveDialogue;

    void Start() {
        Dialogue[0].SetActive(false);

        Scenes[0].SetActive(true);
        SaveChanges();
    }

    void Update() {

    }

    public void NextDialogue() {
        ActiveDialogue++;
        SaveChanges();
    }

    public void NextScene() {
        ActiveScene++;
        ActiveDialogue++;
        SaveChanges();
    }

    public void SkipScene() {
        ActiveScene += 2;
        SaveChanges();
    }

    public void SkipDialogue() {
        ActiveDialogue += 2;
        SaveChanges();
    }

    public void SaveChanges() {
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == ActiveScene);
        }

        for (int i = 0; i < Dialogue.Length; i++)
        {
            Dialogue[i].SetActive(i == ActiveDialogue);
        }
    }

    public void StartButton() {
        Dialogue[0].SetActive(true);

        ActiveScene = 1;
        SaveChanges();
    }

    public void GetInButton()
    {
        ActiveScene = 3;
        ActiveDialogue = 4;
        SaveChanges();
    }

    public void WalkHomeButton()
    {
        ActiveDialogue = 5;
        SaveChanges();
    }

    public void GoToGarage()
    {
        ActiveDialogue = 12;
        SaveChanges();
    }

    public void ApologizeButton() {
        NextDialogue();
    }

    public void StaySilentButton() {
        ActiveScene = 4;
        ActiveDialogue = 12;
        SaveChanges();
    }

    public void GoInButton() {
        ActiveScene = 5;
        ActiveDialogue = 15;
        SaveChanges();
    }

    public void RunAwayButton() {
        ActiveDialogue = 22;
        BadEnding();
    }

    public void SitButton() {
        NextDialogue();
        GoodEnding();
    }

    public void GoToRoomButton() {
        ActiveDialogue = 26;
        BadEnding();
    }

    public void GoodEnding()
    {
        ActiveScene = 6;
        ActiveDialogue = 17;
        SaveChanges();
    }

    public void BadEnding()
    {
        ActiveScene = 7;
        SaveChanges();
    }

    public void BadEndingText()
    {
        ActiveDialogue = 32;
        SaveChanges();
    }

    public void Leave() {
        Application.Quit();
    }
}
