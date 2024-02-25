using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveCheck : MonoBehaviour
{
    public GameObject firstValve;
    public GameObject secondValve;
    public GameObject thirdValve;

    double firstRotZ;
    double secondRotZ;
    double thirdRotZ;

    bool firstFlag = false;
    bool secondFlag = false;
    bool thirdFlag = false;

    private void FixedUpdate()
    {
        firstRotZ = firstValve.transform.localRotation.eulerAngles.z;
        secondRotZ = secondValve.transform.eulerAngles.z;
        thirdRotZ = thirdValve.transform.eulerAngles.z;

        if (firstRotZ > 170 && firstRotZ < 190)
            firstFlag = true;
        else
            firstFlag = false;
        if (secondRotZ > 80 && secondRotZ < 100)
            secondFlag = true;
        else
            secondFlag = false;
        if (thirdRotZ > 260 && thirdRotZ < 280)
            thirdFlag = true;
        else
            thirdFlag = false;

        if (firstFlag && secondFlag && thirdFlag)
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
