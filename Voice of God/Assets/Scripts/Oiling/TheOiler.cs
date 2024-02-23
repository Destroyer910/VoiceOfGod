using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheOiler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Oilable")
        {
            other.gameObject.GetComponent<OilCheck>().oilSelf();
        }    
    }
}
