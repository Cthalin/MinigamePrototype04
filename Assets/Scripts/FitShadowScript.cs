using UnityEngine;
using System.Collections;

public class FitShadowScript : MonoBehaviour {

    public GameObject RotObj;
    public GameObject Shadow;
    private Quaternion _objRotation;
    private float _shadowRotation;
    private Transform _shadowTransform;
    public GameObject EndScreen;
    private bool _fits=false;

    void Start()
    {
        _shadowRotation = Shadow.transform.eulerAngles.z;
        _shadowTransform = Shadow.transform;
    }

    void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            if (RotObj.transform.eulerAngles.z <= _shadowRotation + 10 && RotObj.transform.eulerAngles.z >= -90 + 10)
            {
                _fits = true;
                EndScreen.SetActive(true);
            }
            else if (!(RotObj.transform.eulerAngles.z <= _shadowRotation + 10 && RotObj.transform.eulerAngles.z >= -90 + 10))
            {
                _fits = false;
                print("Möp");
                EndScreen.SetActive(false);
            }
        }        
    }
}
