using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookScript : MonoBehaviour
{
    public float mouseSens = 600;
    float xRotation = 0f;

    public Transform playerBody;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouseSens = GameManager.instance.mouseSens;
    }

    void Update()
    {
        if(GameManager.instance.IsInputEnabled)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
    
    public void ChangeMouseSensitivity(float mouseSensSlider)
    {
        mouseSens = mouseSensSlider;
        GameManager.instance.mouseSens = mouseSens;
    }
}
