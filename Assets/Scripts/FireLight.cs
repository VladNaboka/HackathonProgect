using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLight : MonoBehaviour
{
    public GameObject lights;
    public GameObject lightERROR;
    public void LightOn()
    {
        lights.SetActive(true);
        lightERROR.SetActive(false);
    }
}
