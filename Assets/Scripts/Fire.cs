using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public ParticleSystem FireParticle;
    private void Start()
    {
        FireParticle.Pause();
    }
    public void FirePartOn()
    {
        FireParticle.Play();
    }
    public void FirePartOFF()
    {
        FireParticle.Pause();
        FireParticle.Clear();
    }
}
