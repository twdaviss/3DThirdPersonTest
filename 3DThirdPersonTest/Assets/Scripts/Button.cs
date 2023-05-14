using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{



    public bool buttonActivated = false;
    private int collisions = 0;
    private Color color;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collisions > 0)
        {
            buttonActivated = true;
        }
        else
        {
            buttonActivated = false;
        }

        if (buttonActivated)
        {
            color = Color.green;
            color.a = 0.5f;
            GetComponent<SpriteRenderer>().color = color;

        }
        else
        {
            color = Color.blue;
            GetComponent<SpriteRenderer>().color = color;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            collisions++;
        }





    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            collisions--;
        }
    }
}
