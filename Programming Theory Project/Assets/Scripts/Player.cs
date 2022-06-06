using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float verticalInput;
    private Rigidbody playerRb;
    //Encapsulation
    [SerializeField] private float speed;
    [SerializeField] private float xRange = 2;
    [SerializeField] private float jumpForce;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Abstraction
        Jump();
        VerticalMovement();
        Boundary();

    }

    public void VerticalMovement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * verticalInput);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void Boundary()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    public void Capture()
    { 
    
    }
}
