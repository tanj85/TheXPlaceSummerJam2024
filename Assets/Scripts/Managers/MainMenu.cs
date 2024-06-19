using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Animator anim;
    public string gameScene = "Scene_VL";
    public string tutorialScene = "Tutorial";
    public PersistentData data;
    public TextMeshProUGUI usernameText;

    void Start()
    {
        anim.Play("Player_Run_Down_Loop");
        AudioManager.GetSoundtrack("BossTheme").Play();
        data.LoadSave(0);
    }

    public void PlayGame(){
        SceneManager.LoadScene(gameScene);
    }

    public void PlayTutorial(){
        SceneManager.LoadScene(tutorialScene);
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void GrabFromInputField(string input){
        data.playerName = input;
        DisplayReactionToInput();
    }

    public void DisplayReactionToInput(){
        usernameText.text = data.playerName;
    }
}
