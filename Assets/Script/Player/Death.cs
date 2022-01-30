using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other){
        Robot player = other.GetComponent<Robot>();
        Debug.Log("LAMORT");
        if(player != null){
            Debug.Log("LEROBO");
            player.ChangeBattery(-player.getCurrentBattery());
            LevelBar.setTimeLeft(0);
        }
        Destroy(player.gameObject);
        Debug.Log("APULEROBO");

    }
}
