using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristauxCyan : MonoBehaviour
{
    public GameObject particlesEffect;
    public AudioClip collectedClip;
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
        if(player != null){
            Instantiate(particlesEffect, transform.position, Quaternion.identity);
            if(player.getCurrentColor() == Color.white || player.getCurrentColor() == new Color(30,248,226))
            {
                player.enablePowerCyan();
            }
            else if(player.getCurrentColor() == Color.yellow)
            {
                player.enablePowerGreen();
            }
            else if(player.getCurrentColor() == Color.green)
            {
                player.enablePowerTurquoise();
            }
            else if(player.getCurrentColor() == new Color(215,255,18))
            {
                player.enablePowerGreen();
            }
            //player.addColor(Color.cyan);
            player.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
