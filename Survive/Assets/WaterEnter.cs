using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnter : MonoBehaviour
{
    BoxCollider col;

    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            if (!other.gameObject.GetComponent<Player>().canSwim)
                col.isTrigger = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            if (other.gameObject.GetComponent<Player>().canSwim)
                col.isTrigger = true;
    }
}
