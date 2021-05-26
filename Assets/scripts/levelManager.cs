using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    static AudioSource switc;
    public Text tags;

    // Start is called before the first frame update
    void Start()
    {
        switc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void sfx2()
    {
        if (switc)
        {
            switc.Play();
        }
            
    }
    
}
