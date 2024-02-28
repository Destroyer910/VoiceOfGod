using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour
{

    public bool isPlugged;

    public bool plugToAny;

    public LockedButton buttonScript;

    public GameObject plugThing;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Plug" && plugToAny)
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            gameObject.transform.position = other.gameObject.transform.GetChild(0).transform.position;
            gameObject.transform.rotation = other.gameObject.transform.GetChild(0).transform.rotation;
            isPlugged = true;
            if(buttonScript != null)
            {
                buttonScript.tryUnlockButton();
            }
        }
        else if(other.gameObject == plugThing)
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            gameObject.transform.position = other.gameObject.transform.GetChild(0).transform.position;
            gameObject.transform.rotation = other.gameObject.transform.GetChild(0).transform.rotation;
            isPlugged = true;
            if(buttonScript != null)
            {
                buttonScript.tryUnlockButton();
            }
        }    
    }
}
