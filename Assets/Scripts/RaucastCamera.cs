using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaucastCamera : MonoBehaviour
{
    public float distance = 3;
    public GameObject obj;
    Ray ray;
    void Update()
    {
        //Ray ray = new Ray(transform.position, transform.forward);
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            obj.transform.position = hit.point;
            //if (hit.collider.gameObject.name == "but1" && Input.GetMouseButtonDown(0))
            //{
            //    //SceneManager.LoadScene("SituationOne");
            //    Debug.Log("Click");
            //}
        }
    }
}
