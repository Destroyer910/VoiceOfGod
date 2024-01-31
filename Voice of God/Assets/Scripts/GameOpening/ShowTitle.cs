using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTitle : MonoBehaviour
{
    public GameObject text;
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            text.SetActive(true);
        }
    }
}
