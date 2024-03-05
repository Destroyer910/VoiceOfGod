using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaricaseTeleporter : MonoBehaviour
{
    [SerializeField] GameObject targetObject;
    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = targetObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = targetPosition;
    }
}
