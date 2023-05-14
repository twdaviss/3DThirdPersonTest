using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] GameObject otherDoor;
    bool isActivated = false;
    private int collisions = 0;
    [SerializeField] private GameObject gameOverUI;

    [SerializeField] bool theEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collisions > 0)
        {
            isActivated = true;
        }
        else
        {
            isActivated = false;
        }
        if ( isActivated && otherDoor.GetComponent<Exit>().isActivated == true)
        {
            if (theEnd)
            {
                //Time.timeScale = 0;
                gameOverUI.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collisions++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collisions--;
        }
    }
}
