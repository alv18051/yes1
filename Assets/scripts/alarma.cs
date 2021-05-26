using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarma : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Light>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Light>().enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
            GetComponent<Light>().intensity = Mathf.Abs(Mathf.Sin(Time.time));        }

    }
}
