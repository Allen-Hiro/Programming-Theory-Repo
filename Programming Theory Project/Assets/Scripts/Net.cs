using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour
{
    [SerializeField] private float netSpawnTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        DestroyNetDelay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
    void DestroyNetDelay()
    {
        Destroy(gameObject, netSpawnTime);
    }
}
