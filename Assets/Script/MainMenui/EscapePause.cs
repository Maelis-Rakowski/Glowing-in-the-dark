using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EscapePause : MonoBehaviour
{

    public GameObject exitButton;
    public GameObject restartButton;

    private bool gamePause;
    
    
    public void quitMenu(){
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }

    // Start is called before the first frame update
    void Start()
    {
        gamePause = false;
        LevelBar.gameOver = false;
        Time.timeScale = 1;
        deactiveButton();
    }

    // Update is called once per frame
    void Update()
    {
        if(LevelBar.gameOver){
            gamePause = true;
            Time.timeScale = 0;
            activeButton();
        }else if(Input.GetKeyDown(KeyCode.Escape)&& !LevelBar.gameOver){
            gamePause = !gamePause;
            if(Time.timeScale == 0){
                Time.timeScale = 1;
                deactiveButton();
            }else{
                Time.timeScale = 0;
                activeButton();
            }
        }
    }

    public void activeButton(){
        restartButton.SetActive(true);
        exitButton.SetActive(true);
    }

    public void deactiveButton(){
        exitButton.SetActive(false);
        restartButton.SetActive(false);
    }
}
