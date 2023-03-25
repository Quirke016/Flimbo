using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLook : MonoBehaviour
{
    public float playerSensitivity = 200f;
    float playerXSensitivity;
    float playerYSensitivity;
    float xRot = 0f;
    public Transform playerBody;
    Slider sensSlider;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Sens(float sensitivity)
    {
       playerSensitivity = sensitivity;
    }

    void Update()
    {
        playerXSensitivity = playerSensitivity;
        playerYSensitivity = playerSensitivity * 0.8f;

        float mouseX = Input.GetAxis("Mouse X") * playerXSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * playerYSensitivity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -85f, 85f);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
