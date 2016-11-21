using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour {

    public float RotSpeed = 10;
    public float ZMultiplier = 2;
    public GameObject LeftButton;
    public GameObject RightButton;
    private bool _rotateLeftButtonPressed = false;
    private bool _rotateRightButtonPressed = false;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * RotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * RotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up * Time.deltaTime, -rotX * 40, Space.World);
        transform.Rotate(Vector3.right * Time.deltaTime, rotY * 40, Space.World);
    }

    void Update()
    {
        if (_rotateLeftButtonPressed)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * RotSpeed * ZMultiplier, Space.World);
        } else if (_rotateRightButtonPressed)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * RotSpeed * ZMultiplier, Space.World);
        }
    }

    public void onPointerDownRotateLeftButton()
    {
        _rotateLeftButtonPressed = true;
    }
    public void onPointerUpRotateLeftButton()
    {
        _rotateLeftButtonPressed = false;
    }
    public void onPointerDownRotateRightButton()
    {
        _rotateRightButtonPressed = true;
    }
    public void onPointerUpRotateRightButton()
    {
        _rotateRightButtonPressed = false;
    }
}
