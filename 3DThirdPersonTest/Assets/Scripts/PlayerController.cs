using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpForce;

    [SerializeField] Transform groundCheck;

    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask plateLayer;

    private bool isGrounded;
    public bool isOnPlate;

    [SerializeField] bool isPlayer1;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        isOnPlate = Physics2D.OverlapCircle(groundCheck.position, 0.2f, plateLayer);

        switch (isPlayer1) {

            case true:
                if (Input.GetKey(KeyCode.D)) {
                    transform.Translate(transform.right * movementSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-transform.right * movementSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    if (isGrounded)
                    {
                        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    }
                }
                break;
            case false:
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Translate(transform.right * movementSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Translate(-transform.right * movementSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
                {
                    GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }
                break;
        }
        

    }
}
