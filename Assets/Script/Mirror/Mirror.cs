using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{

    public GameObject rayPrefab;
    int countRay;
    public BoxCollider2D ray;
    static GameObject rayObject;

    // Start is called before the first frame update
    void Start()
    {
        countRay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.tag);
        if((other.name.Contains("Mirror") || other.tag == "Light") && countRay == 0) {
            ray.size = new Vector2(0.1f,10f);
            rayObject = Instantiate(rayPrefab, transform.position, transform.rotation);

            countRay++;
            Counter.increment(1);
        }
    }
    public static void destroyRay(){
        Destroy(rayObject);
    }

}
