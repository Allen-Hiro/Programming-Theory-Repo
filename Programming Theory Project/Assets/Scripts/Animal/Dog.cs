using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //Inheritance
{
    [SerializeField] private float dogSpeed; //Encapsulation


    public override void Move()     //Polymorphism
    {
        transform.Translate(Vector3.forward * Time.deltaTime * dogSpeed);
    }
}
