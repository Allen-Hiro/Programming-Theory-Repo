using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private float speed;
    private float mapBoundary = 15;
    void Update()
    {
        Movement();
        AnimalBoundary();
    }

    public void Movement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void AnimalBoundary()
    {
        if (transform.position.z > mapBoundary)
        {
            Destroy(gameObject);
        }
    }
}
