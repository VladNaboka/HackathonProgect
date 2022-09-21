using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBlocks : MonoBehaviour
{
    public string nameScene;
    public bool activScene = false;
    public bool activStart = false;
    public bool activOptions = false;
    public Material mat;

    public Animator animMain;
    private void Start()
    {
        animMain.SetBool("playUpMenuLevels", false);
    }
    private void OnMouseDown()
    {
        if (activScene)
            SceneManager.LoadScene(nameScene);
        if (activStart)
        {
            Debug.Log("Start Game!");
            animMain.SetBool("playUpMenuLevels", true);
        }
        if (activOptions)
        {
            Debug.Log("Open Options!");
        }
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = mat.color;
    }
}
