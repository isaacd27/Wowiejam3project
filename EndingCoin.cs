using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Deathcounter.instance.deaths == 0)
        {

           
        }
        else
        {
            gameObject.transform.position = new Vector2(-999, -999);
            this.enabled = false;
        }
    }

 
}
