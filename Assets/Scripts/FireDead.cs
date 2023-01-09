using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDead : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fireExtinguisher")
        {
            Destroy(gameObject);
        }
    }
}
