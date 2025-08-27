using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class MoveScript : MonoBehaviour
{

    private Vector3 _dragOffset;
    private Camera _cam;

    void Awake()
    {
        _cam = Camera.main;
    }

    void OnMouseDown()
    {
        _dragOffset = transform.position - GetMousePos();
    }

    void OnMouseUp()
    {
    }

    void OnMouseOver()
    {

    }

    void OnMouseDrag()
    {
        transform.position = GetMousePos() + _dragOffset;
    }

    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -3;
        return mousePos;
    }
}
