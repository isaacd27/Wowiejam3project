using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadlyobject : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    private Scene Curlevel;
    [SerializeField]
    public float startX;
    [SerializeField]
    public float startY;

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
            Deathcounter.instance.deaths += 1;
            if (Curlevel == SceneManager.GetSceneByName("Level7"))
            {

                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector2(-4.47f,5.03f);
            }
            else
            {
                SoundScript.playeffect("Playerdeath");
                player.transform.position = new Vector2(startX, startY);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
