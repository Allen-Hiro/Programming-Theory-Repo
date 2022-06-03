using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private Rigidbody catRb;
    private bool onGround = false;
    [SerializeField] private float catJump;
    private void Start()
    {
        catRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Jump();
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
