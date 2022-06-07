using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //Inheritance
{
    private Rigidbody catRb;
    private bool onGround = false;
    [SerializeField] private float catJump; //Encapsulation
    private void Start()
    {
        catRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Jump();
        Move();
        AnimalBoundary();
        onGround = false;
    }

    public void Jump()
    {
        if (onGround == true)
        {
            catRb.AddForce(Vector3.up * catJump, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "Ground")
        {
            onGround = true;
        }
    }
}
