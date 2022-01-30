using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme3 : MonoBehaviour
{
    public GameObject cristauxRosesPrefabs;
    public GameObject lamp;
    public GameObject lightPrefab;
    int limit = 0;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Je suis trigger");
        
        
        if(other.tag == "Light" && lamp.GetComponent<UnityEngine.Rendering.Universal.Light2D>().color == new Color(0.117f, 0.972f, 0.886f) && limit ==0){
            Debug.Log("I'm in");
            for(int i = 0; i<4; i++){
                Vector3 spawn = transform.position;
                spawn.x += -5f +i;
                Instantiate(cristauxRosesPrefabs, spawn, Quaternion.identity);
                
                
            }
            Instantiate(lightPrefab, transform.position, Quaternion.identity);
            limit++;
            
        }
    }
}
