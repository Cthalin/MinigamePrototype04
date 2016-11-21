using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    public float RotSpeed = 10;
    public GameObject LeftButton;
    public GameObject RightButton;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * RotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * RotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up * Time.deltaTime, -rotX * 40, Space.World);
        transform.Rotate(Vector3.right * Time.deltaTime, rotY * 40, Space.World);
    }

    public void RotateZLeft()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime, Space.World);
    }

    public void RotateZRight()
    {

    }
}
