using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] GameObject platform1;
    [SerializeField] GameObject platform2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerController>().isOnPlate)
        {
            platform1.GetComponent<Door>().Disable();
            platform2.GetComponent<Door>().Enable();
        }
        else
        {
            platform2.GetComponent<Door>().Disable();
            platform1.GetComponent<Door>().Enable();
        }
    }
}
