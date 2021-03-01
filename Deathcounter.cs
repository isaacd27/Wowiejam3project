using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathcounter : MonoBehaviour
{
    public static Deathcounter instance;
    public int deaths = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(transform.gameObject);

        if (instance == null)
        {
            instance = this;
        }

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
