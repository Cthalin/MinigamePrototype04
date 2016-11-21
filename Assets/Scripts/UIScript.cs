using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text DotForward;
    public Text DotUp;

    public void SetDotForward(float _dotForward)
    {
        DotForward.text = "_dotForward: " + _dotForward;
    }
    public void SetDotUp(float _dotUp)
    {
        DotUp.text = "_dotUp: " + _dotUp;
    }
}
