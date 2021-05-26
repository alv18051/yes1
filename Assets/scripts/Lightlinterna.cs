using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightlinterna : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            levelManager.sfx2();
        }
    }
}
