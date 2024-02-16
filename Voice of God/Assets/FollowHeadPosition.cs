using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHeadPosition : MonoBehaviour
{

    public GameObject camera;
    private Vector3 tempTransform;


    /* Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position != new Vector3(camera.transform.position.x, gameObject.transform.position.y, camera.transform.position.z))
        {
            camera.transform.SetParent(null, true);
            gameObject.transform.position = new Vector3(camera.transform.position.x, gameObject.transform.position.y, camera.transform.position.z);
            camera.transform.SetParent(gameObject.transform, true);
        }
    }*/
}
