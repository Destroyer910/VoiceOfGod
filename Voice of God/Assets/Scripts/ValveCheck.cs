using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ValveCheck : MonoBehaviour
{
    [SerializeField] private GameObject valveToCheck;
    [SerializeField] private double desiredRotation;

    private EmissionModule particles;

    private void Start()
    {
        particles = this.gameObject.GetComponent<ParticleSystem>().emission; // ParticleSystem is weird, uses structs, don't question it
    }

    private void FixedUpdate()
    {
        float currentAngle = valveToCheck.transform.localRotation.eulerAngles.z;
        // Passes this check if the current angle of the valve is within 10% of the desired angle
        if (currentAngle > (desiredRotation*0.9) && currentAngle < desiredRotation*1.1)
        {
            disableSteam();
        }
        else
        {
            enableSteam();
        }
    }
    private void disableSteam()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        particles.rateOverTime = 0;
    }
    private void enableSteam()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
        particles.rateOverTime = 15;
    }
}
