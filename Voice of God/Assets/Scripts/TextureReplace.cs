using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class TextureReplace : MonoBehaviour
{
    Object[] allObjects;
    public Material TextureToApply;

    bool fired = false;

    void Start()
    {
        allObjects = FindObjectsOfType(typeof(MonoBehaviour));
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !fired) {
            fired = true;
            fireTextures();
        }
        if(Input.GetKeyUp(KeyCode.E)) {
            fired = false;
        }
    }

    void fireTextures() {
        foreach (Object obj in allObjects)
        {
            if(obj.GetComponent<MeshRenderer>() != null)
                obj.GetComponent<MeshRenderer>().SetMaterials = obj.GetComponent<MeshRenderer>().GetMaterials();
        }
    }   
}
