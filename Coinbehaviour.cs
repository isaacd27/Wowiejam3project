using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Coinbehaviour : MonoBehaviour
{
    public static Coinbehaviour instance;
        

    public int coins = 0;
    //public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void changescore(int c)
    {
        coins += c;
       // coinText.text = "Coins: " + coins.ToString();
        Debug.Log(coins);
    }

}
