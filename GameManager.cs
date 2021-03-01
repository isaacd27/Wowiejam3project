using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    Scene whatslevel;
    GameObject player;

   

   // GameObject coins;

   // int coinsgotten = 0;

    public Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        whatslevel = new Scene();


        player = GameObject.Find("Player");
      
    }
     void Awake()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        whatslevel = SceneManager.GetActiveScene();

        player = GameObject.Find("Player");

        //coincollect();

    }

     void LateUpdate()
    {

       // coins = GameObject.Find("Coin");


        if (whatslevel == SceneManager.GetSceneByName("Game"))
        {
            if (player.transform.position.y < -6)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                Debug.Log(player.transform.position.y);
                player.transform.position = new Vector3(-35.52f, -4.43f);

            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }

        }
        else if (whatslevel == null)
        {
            Debug.LogError("Failed to load scene");
            Application.Quit();
        }
        else if (whatslevel == SceneManager.GetSceneByName("Level2"))
        {
            if (player.transform.position.y < -5)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-37.9f, -3.2f);
            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }
        }
        else if (whatslevel == SceneManager.GetSceneByName("Level3"))
        {
            if (player.transform.position.y < -17)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-62.62f, -2.15f);
            }
            else if (player.transform.position == null)
            {

                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }
        }
        else if (whatslevel == SceneManager.GetSceneByName("Level4"))
        {
            if (player.transform.position.y < -5)
            {

                SceneManager.LoadScene("Level6");
            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }

        }
        else if (whatslevel == SceneManager.GetSceneByName("Level5"))
        {
            if (player.transform.position.y < -7)
            {

                SceneManager.LoadScene("Level4");
            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }
        }
        else if (whatslevel == SceneManager.GetSceneByName("Level7"))
        {
            if (player.transform.position.y < 0)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-4.47f, 5.03f);
            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }
        }
        else if (whatslevel == SceneManager.GetSceneByName("Level8"))
        {
           if(Coinbehaviour.instance.coins == 5)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                SceneManager.LoadScene("Level8");
            }

        }else if (whatslevel == SceneManager.GetSceneByName("Level9"))
        {
            if (player.transform.position.y < -5)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-21.12f, 1.87f);
            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }
        }else if (whatslevel == SceneManager.GetSceneByName("Leve10"))
        {
            if (Coinbehaviour.instance.coins == 6)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                SceneManager.LoadScene("Level10");
            }
           else  if (player.transform.position.y < -6) // doesn't get checked for no reason

            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-14.2f, -2.6f);
            }


        }
        else if (whatslevel == SceneManager.GetSceneByName("Level11"))
        {
            if (Coinbehaviour.instance.coins >= 1)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");

                SceneManager.LoadScene("Level11");
            }

            else if (player.transform.position.y < -6)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-7.79f, -3.04f);
            }
        }else if (whatslevel == SceneManager.GetSceneByName("level13"))
        {
            if (player.transform.position.y < -6)
            {
                
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-7.96f, 1.15f);
                Deathcounter.instance.deaths += 1;
            }
        }
        else if(whatslevel == SceneManager.GetSceneByName("level14"))
        {
            if (player.transform.position.y < -6)
            {

                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector3(-8.24f, -2.75f);
                Deathcounter.instance.deaths += 1;
            }
            if (Coinbehaviour.instance.coins >= 1)
            {
                Deathcounter.instance.deaths += 1;
                SoundScript.playeffect("Playerdeath");
                SceneManager.LoadScene("Level14");
            }
        }

    }

 
}
