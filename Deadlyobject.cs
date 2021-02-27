using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadlyobject : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    private Scene Curlevel;

    void Awake()
    {
        player = GameObject.Find("Player");
        Curlevel = SceneManager.GetActiveScene();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           if(Curlevel == SceneManager.GetSceneByName("Level7"))
            {
                player.transform.position = new Vector2(-4.47f,5.03f);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
