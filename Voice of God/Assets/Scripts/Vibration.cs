using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    void Start()
    {
        xr = (XRController) GameObject.FindObjectOfType(typeof(XRController));
    }
    void Rumble(float amplitude, duration) {
        xr.SendHapticImpulse(amplitude, duration);
    }
}
