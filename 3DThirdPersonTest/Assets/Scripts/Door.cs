using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject button;

    [SerializeField] bool door = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (door)
        {
            if (button.GetComponent<Button>().buttonActivated == true)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }

    }
    public void Disable()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().color = Color.blue;
    }
    
    public void Enable()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        Color color = Color.green;
        color.a = 0.2f;
        GetComponent<SpriteRenderer>().color = color;
    }
}
