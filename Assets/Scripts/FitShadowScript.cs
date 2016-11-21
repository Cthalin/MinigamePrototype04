using UnityEngine;
using System.Collections;

public class FitShadowScript : MonoBehaviour {

    public GameObject RotObj;
    public GameObject Shadow;
    private Quaternion _objRotation;
    private float _shadowRotation;
    public GameObject EndScreen;

    void Start()
    {
        _shadowRotation = Shadow.transform.eulerAngles.z;
    }

    void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            //if (RotObj.transform.rotation.z >= (Shadow.transform.rotation.z - Shadow.transform.rotation.z / 20) && RotObj.transform.rotation.z <= (Shadow.transform.rotation.z + Shadow.transform.rotation.z / 20))
            //{
            //    EndScreen.SetActive(true);
            //}
            //else if (RotObj.transform.rotation.z <= -(Shadow.transform.rotation.z - Shadow.transform.rotation.z / 20) && RotObj.transform.rotation.z >= -(Shadow.transform.rotation.z + Shadow.transform.rotation.z / 20))
            //{
            //    EndScreen.SetActive(true);
            //}

            //if (RotObj.transform.rotation.z <= (Shadow.transform.rotation.z - Shadow.transform.rotation.z / 20) || RotObj.transform.rotation.z >= (Shadow.transform.rotation.z + Shadow.transform.rotation.z / 20))
            //{
            //    EndScreen.SetActive(false);
            //}

            if (RotObj.transform.eulerAngles.z <= _shadowRotation + 10 && RotObj.transform.eulerAngles.z >= -90 + 10)
            {
                EndScreen.SetActive(true);
            }
            else if (RotObj.transform.rotation.z <= _shadowRotation - 10 || RotObj.transform.rotation.z >= _shadowRotation + 10)
            {
                EndScreen.SetActive(false);
            }
        }
        
    }
}
