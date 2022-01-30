using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Counter : MonoBehaviour {

    public TextMeshProUGUI textScore;
    public int maximum;
    static int max;
    static int total;

    void Start(){
        total = 0;
        setMax(maximum);
    }

    // Update is called once per frame
    void Update()
    {
        victoire();
        textScore.text = "Score : " + total.ToString() + " / " + max.ToString();
    }

    public static void increment(int value){
        total += value;
    }

    public static void setTotal(int value){
        total = value;
    }

    public void setMax(int value){
        max = value;
    }

    public static bool victoire(){
        if(max == total) {
            return true;
        }
    
        return false;
    }    
}
