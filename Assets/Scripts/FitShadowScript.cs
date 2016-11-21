using UnityEngine;
using System.Collections;

public class FitShadowScript : MonoBehaviour {

    public GameObject RotObj;
    public GameObject Shadow;
    //private float _shadowRotation;
    //private Transform _shadowTransform;
    public GameObject EndScreen;
    private Vector3 _shadowForward;
    private Vector3 _shadowUp;
    private float _dotForward;
    private float _dotUp;

    void Start()
    {
        //_shadowRotation = Shadow.transform.eulerAngles.z;
        //_shadowTransform = Shadow.transform;
        _shadowForward = Shadow.transform.forward;
        _shadowUp = Shadow.transform.up;
    }

    void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            //if (RotObj.transform.eulerAngles.z <= _shadowRotation + 10 && RotObj.transform.eulerAngles.z >= -90 + 10)
            //{
            //    _fits = true;
            //    EndScreen.SetActive(true);
            //}
            //else if (!(RotObj.transform.eulerAngles.z <= _shadowRotation + 10 && RotObj.transform.eulerAngles.z >= -90 + 10))
            //{
            //    _fits = false;
            //    print("Möp");
            //    EndScreen.SetActive(false);
            //}

            _dotForward = Vector3.Dot(RotObj.transform.forward, _shadowForward);
            _dotUp = Vector3.Dot(RotObj.transform.up, _shadowUp);

            print(_dotForward);
            print(_dotUp);

            if (_dotForward <= 1.02 && _dotForward >= 0.98 && _dotUp <= 1.02 && _dotUp >= 0.98)
            {
                print("Dot fit");
                EndScreen.SetActive(true);
            } else if (!(_dotForward <= 1.02 && _dotForward >= 0.98 && _dotUp <= 1.02 && _dotUp >= 0.98))
            {
                print("Dot not fit");
                EndScreen.SetActive(false);
            }
        }        
    }
}
