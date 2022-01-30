using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        while(transform.localScale.y < 1){
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + 0.01f, transform.localScale.z );
        }
    }


}
