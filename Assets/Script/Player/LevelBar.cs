using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour {

    public static LevelBar instance { get; private set; }
    Image timeBar;
   static float maxTime = Robot.getMaxBattery();
    static float timeLeft;
    public GameObject timesUpText;
    public static bool gameOver = false;
    static int tempsBonus = 5;

    private void Awake()
    {
        instance = this;
    }

    void Start(){
        timesUpText.SetActive(false);
        timeBar = GetComponent<Image> ();
        timeLeft = maxTime;
    }


    public static void setTimeLeft(int value){
        timeLeft = value;
    }


    void Update(){
        
        if(timeLeft > 0){
            timeLeft -= Time.deltaTime;
           timeBar.fillAmount = timeLeft / maxTime;
        } else {
            timesUpText.SetActive (true);
            Time.timeScale = 0;
            gameOver = true;
        }
    }

    public static void recharge(int value){
        if(value > 0){
            if(timeLeft + tempsBonus > maxTime){
                timeLeft = maxTime;
            }
            else {
                timeLeft = timeLeft + tempsBonus;
            }
        }
    }
}
