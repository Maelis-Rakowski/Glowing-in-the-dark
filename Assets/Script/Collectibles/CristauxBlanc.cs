using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristauxBlanc : MonoBehaviour
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

        if (player != null)
        {
            Instantiate(particlesEffect, transform.position, Quaternion.identity);
            player.ChangeBattery(1);
            player.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
