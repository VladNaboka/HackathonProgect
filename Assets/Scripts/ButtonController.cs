using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject player;   
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    public void ButStartScene()
    {
        SceneManager.LoadScene(1);
        player.transform.position = new Vector3(-4.289f, -2.025f, -6.402f);
    }
    public void FireScene()
    {
        SceneManager.LoadScene(2);
        player.transform.position = new Vector3(-4.289f, -2.025f, -6.402f);
    }
    public void StartScene()
    {
        SceneManager.LoadScene(0);
        player.transform.position = new Vector3(0, 0.8f, 0.4f);
    }
    public void KPP()
    {
        SceneManager.LoadScene(3);
        player.transform.position = new Vector3(0.4110122f, 1.065283f, -1.743155f);
    }
    public void BUS()
    {
        SceneManager.LoadScene(5);
        player.transform.position = new Vector3(-0.463f, 0.812f, 0f);
        Destroy(player);
    }
    public void KPPFire()
    {
        SceneManager.LoadScene(6);
        player.transform.position = new Vector3(0.4110122f, 1.065283f, -1.743155f);
    }
}
