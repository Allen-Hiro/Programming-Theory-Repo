using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] private GameObject net;
    //Encapsulation
    [SerializeField] private float speed;
    [SerializeField] private float xRange = 2;
    [SerializeField] private float jumpForce;
    [SerializeField] private float offsetZ = 1;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Abstraction
        VerticalMovement();
        Boundary();
        Capture();
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
        Vector3 netSpawnPos = new Vector3(transform.position.x, transform.position.y, (transform.position.z - offsetZ));
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(net, netSpawnPos, net.transform.rotation);
        }
    }
}
