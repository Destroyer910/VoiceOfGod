using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Vibration : MonoBehaviour
{
    ActionBasedController xr;
    void Start()
    {
        xr = (ActionBasedController) GameObject.FindObjectOfType(typeof(ActionBasedController));
    }
    void Update() {
        rumble(1f,0.1f);
    }
    void rumble(float amplitude, float duration) {
        xr.SendHapticImpulse(amplitude, duration);
    }
}
