using UnityEngine;
using System.Collections;

public class FitShadowScript : MonoBehaviour {

    public GameObject RotObj;
    public GameObject Shadow;
    public GameObject EndScreen;
    private Vector3 _shadowForward;
    private Vector3 _shadowUp;
    private float _dotForward;
    private float _dotUp;
    public UIScript UIScript;

    void Start()
    {
        _shadowForward = Shadow.transform.forward;
        _shadowUp = Shadow.transform.up;
        UIScript = GetComponent<UIScript>();
    }

    void Update () {

        _dotForward = Vector3.Dot(RotObj.transform.forward, _shadowForward);
        _dotUp = Vector3.Dot(RotObj.transform.up, _shadowUp);

        UIScript.SetDotForward(_dotForward);
        UIScript.SetDotUp(_dotUp);

        if (Input.GetMouseButtonUp(0))
        {
            if (_dotForward <= 1.02 && _dotForward >= 0.98 && _dotUp <= 1.02 && _dotUp >= 0.98)
            {
                EndScreen.SetActive(true);
            } else if (!(_dotForward <= 1.02 && _dotForward >= 0.98 && _dotUp <= 1.02 && _dotUp >= 0.98))
            {
                EndScreen.SetActive(false);
            }
        }        
    }

    public float GetDotForward()
    {
        return _dotForward;
    }
}
