using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Level 1");
    }       

    public void GoToSettigsMenu(){
        SceneManager.LoadScene("MenuSetting");
    }

    public void GoToMainMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void lvlSelec(){
        SceneManager.LoadScene("LevelSelector");
    }
}
