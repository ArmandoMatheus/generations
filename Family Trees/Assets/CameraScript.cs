using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    float panSpeed = 20f;
    float panLimitX = 10f;
    float panLimitY = 6f;
    float scrollSpeed = 10f;
    float panSizeMax = 21f;
    float panSizeMin = 7f;

    private Camera panCam;

    void Awake()
    {
        panCam = Camera.main;
    }

    void Update()
    {
        Vector3 camPos = transform.position;

        if (Input.GetKey("w"))
        {
            camPos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            camPos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            camPos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            camPos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        panCam.orthographicSize -= scroll * scrollSpeed * 100f * Time.deltaTime;
        panCam.orthographicSize = Mathf.Clamp(panCam.orthographicSize, panSizeMin, panSizeMax);


        panLimitX = ((panSizeMax - panCam.orthographicSize) * 1.75f);
        panLimitY = (panSizeMax - panCam.orthographicSize);

        camPos.x = Mathf.Clamp(camPos.x, -panLimitX, panLimitX);
        camPos.y = Mathf.Clamp(camPos.y, -panLimitY, panLimitY);
        transform.position = camPos;

    }
}
