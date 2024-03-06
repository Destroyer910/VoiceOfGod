using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] private GameObject stairObject;
    private Vector3 targetPosition;
    private bool fired = false;
    private float numRotations;
    private float offset;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            createNew();
        }
    }

    private void Start()
    {
        if(transform.parent.name.Contains("Stackable"))
        {
            offset = 4.4219f;
        } else
        {
            offset = 4.4625f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        createNew();
    }

    private void createNew()
    {
        if (!fired)
        {
            fired = true;
            Instantiate(stairObject, new Vector3(transform.parent.gameObject.transform.position.x, transform.parent.gameObject.transform.position.y + offset, transform.parent.gameObject.transform.transform.position.z), transform.parent.gameObject.transform.rotation);
        }
    }
}
