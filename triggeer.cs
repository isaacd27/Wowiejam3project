using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggeer : MonoBehaviour
{

    [SerializeField]
    private string Nextlevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int c = Coinbehaviour.instance.coins;

            Coinbehaviour.instance.changescore(-c);

            SceneManager.LoadScene(Nextlevel);
        }
    }
    // Start is called before the first frame update
}
