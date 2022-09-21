using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float xRot = 0f;
    float moveX;
    float moveY;
    float speed = 500f;
    public Transform player;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        moveX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        moveY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        xRot -= moveY;
        xRot = Mathf.Clamp(xRot, -70f, 70f);
        transform.localRotation = Quaternion.Euler(xRot, 0, 0);

        player.Rotate(0, moveX, 0);
    }
}
