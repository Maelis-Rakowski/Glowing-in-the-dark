using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristauxJaune : MonoBehaviour
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
            if(player.getCurrentColor() == Color.white || player.getCurrentColor() == new Color(215,255,18))
            {
                player.enablePowerYellow();
            }
            else if(player.getCurrentColor() == Color.cyan)
            {
                player.enablePowerGreen();
            }
            else if(player.getCurrentColor() == Color.green)
            {
                player.enablePowerGreenYellow();
            }
            else if(player.getCurrentColor() == new Color(30,248,226))
            {
                player.enablePowerGreen();
            }
            //player.addColor(Color.yellow);
            player.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
