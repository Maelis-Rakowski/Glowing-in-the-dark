using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristauxRouge : MonoBehaviour
{
    public GameObject particlesEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Robot player = other.GetComponent<Robot>();
        if(player != null ){
            Debug.Log("PLAYER WSH");
        }
        if(player == null){
            Debug.Log("Where is bryan");
        }
        

        /*if (player != null)
        {
            Instantiate(particlesEffect, transform.position, Quaternion.identity);
            player.enablePowerRouge();
            Destroy(gameObject);
        }*/
    }
}
