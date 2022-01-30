using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public GameObject[] cristaux;
    bool solved = false;
    int max;

    void Start()
    {
        foreach (GameObject gameObject in cristaux)
            {
                gameObject.SetActive(false);
            }
        max = cristaux.Length;
    }


    // Update is called once per frame
    void Update()
    {
        if(solved == false){
            if(Counter.victoire() == true){
                foreach (GameObject gameObject in cristaux)
                {
                    gameObject.SetActive(true);
                }
                solved = true;
            }             
        }
    }
}
