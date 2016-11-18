using UnityEngine;
using System.Collections;

public class FitShadowScript : MonoBehaviour {

    public GameObject RotObj;
    public GameObject Shadow;
    private Quaternion _objRotation;
    private Quaternion _shadowRotation;
    public GameObject EndScreen;

    void Update () {

        if (RotObj.transform.rotation.z >= (Shadow.transform.rotation.z - Shadow.transform.rotation.z/20) && RotObj.transform.rotation.z <= (Shadow.transform.rotation.z + Shadow.transform.rotation.z / 20))
        {
            EndScreen.SetActive(true);
        }
        else if(RotObj.transform.rotation.z <= -(Shadow.transform.rotation.z - Shadow.transform.rotation.z / 20) && RotObj.transform.rotation.z >= -(Shadow.transform.rotation.z + Shadow.transform.rotation.z / 20))
        {
            EndScreen.SetActive(true);
        }

        if (RotObj.transform.rotation.z <= (Shadow.transform.rotation.z - Shadow.transform.rotation.z / 20) || RotObj.transform.rotation.z >= (Shadow.transform.rotation.z + Shadow.transform.rotation.z / 20))
        {
            EndScreen.SetActive(false);
        }
    }
}
