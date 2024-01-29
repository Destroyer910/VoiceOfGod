using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGrabableThing : MonoBehaviour 
{
    public Transform handler;
    public Rigidbody HandlerRB;

    private void Start() {
        HandlerRB = handler.GetComponent<Rigidbody>();
    }

    private void Update() {
        transform.position = handler.position;
        transform.rotation = handler.rotation;

        HandlerRB.velocity = Vector3.zero;
        HandlerRB.angularVelocity = Vector3.zero;
    }
}
