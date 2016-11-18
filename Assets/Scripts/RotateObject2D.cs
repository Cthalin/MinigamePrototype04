using UnityEngine;
using System.Collections;

public class RotateObject2D : MonoBehaviour {

	public float RotSpeed = 10;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * RotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.forward, -rotX * 40, Space.World);
    }
}
