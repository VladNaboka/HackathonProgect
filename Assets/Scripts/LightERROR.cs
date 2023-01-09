using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightERROR : MonoBehaviour
{
    public GameObject particles;
    public GameObject lights;
    public GameObject Fleshlight;
    //public Light lights;

    public void LightOFF()
    {
        particles.SetActive(false);
        lights.SetActive(false);
    }
    public void PickUp()
    {
        Fleshlight.SetActive(true);
    }
}
