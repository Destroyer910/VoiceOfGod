using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    private GameObject stairObject;
    private Vector3 targetPosition;
    private bool fired = false;
    private float numRotations;
    void Start()
    {
        stairObject = transform.parent.gameObject;
        numRotations = (transform.position.y / 6.227f) + 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!fired) {
            fired = true;
            Quaternion rot = Quaternion.identity;
            rot.eulerAngles = new Vector3(transform.parent.gameObject.transform.rotation.x, transform.parent.gameObject.transform.rotation.y + (342.49f*numRotations), transform.parent.gameObject.transform.rotation.z);
            Instantiate(stairObject, new Vector3(transform.parent.gameObject.transform.position.x, transform.parent.gameObject.transform.position.y + 6.227f, transform.parent.gameObject.transform.transform.position.z), Quaternion.Euler(transform.parent.gameObject.transform.rotation.x, transform.parent.gameObject.transform.rotation.y + 342.49f, transform.parent.gameObject.transform.rotation.z));
        }
    }
}
