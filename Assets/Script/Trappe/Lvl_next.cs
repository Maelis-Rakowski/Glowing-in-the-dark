using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_next : MonoBehaviour
{
    public int objectif_c;
    public GameObject trape;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Robot>() != null)
        {
            int points = collision.GetComponent<Robot>().getPoint();
            if(points == objectif_c)
            {
                trape.SetActive(false);
            }

        }
    }


}
