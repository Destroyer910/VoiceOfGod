using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoorOnActivate : MonoBehaviour
{
    public GameObject doorToUnlock;
    void Start()
    {
       doorToUnlock.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

}
