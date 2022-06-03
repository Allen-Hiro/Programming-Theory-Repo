using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float verticalInput;
    [SerializeField] private float speed;
    [SerializeField] private float xRange = 2;

    void Start()
    {
        
    }

    void Update()
    {
        VerticalMovement();
        Boundary();
    }

    public void VerticalMovement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * verticalInput);
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
