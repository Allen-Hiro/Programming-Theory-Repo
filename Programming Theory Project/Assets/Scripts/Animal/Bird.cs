using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal //Inheritance
{
    [SerializeField] private float birdSpeed; //Encapsulation

    //Inheritance
    public override void Move()     //Polymorphism
    {
        transform.Translate(Vector3.forward * Time.deltaTime * birdSpeed);
    }
}
