using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class V : MonoBehaviour
{
   
    public void OnValueChanged(float newValue)
    {
       // DontDestroyOnLoad(transform.gameObject);
        GetComponent<AudioSource>().volume = newValue;
     
    }

  
  
   
}
 
  

