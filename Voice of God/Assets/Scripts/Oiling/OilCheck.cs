using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilCheck : MonoBehaviour
{
    public bool amIOiled = false;

    public Material oiledMat;

    public void oilSelf()
    {
        if(!amIOiled)
        {
            amIOiled = true;
            gameObject.GetComponent<MeshRenderer>().material = oiledMat;
        }
    }
}
