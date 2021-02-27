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
                SceneManager.LoadScene("Level8");
            }

        }else if (whatslevel == SceneManager.GetSceneByName("Level9"))
        {
            if (player.transform.position.y < -5)
            {

                player.transform.position = new Vector3(-21.12f, 1.87f);
            }
            else if (player.transform.position == null)
            {
                Debug.LogError("Could not find player");
                player.transform.position = new Vector3(0f, 0f);
            }
        }

    }

 
}
