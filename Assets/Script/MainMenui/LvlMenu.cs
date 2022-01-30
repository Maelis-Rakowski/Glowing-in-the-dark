using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LvlMenu : MonoBehaviour
{
     public void goLvl1(){

        SceneManager.LoadScene("Level 1");
    }

    public void goLvl2(){
        SceneManager.LoadScene("Level 2");
    }

    public void goLvl3(){
        SceneManager.LoadScene("Level 3");
    }

    public void back(){
        SceneManager.LoadScene("Menu");
    }
}
