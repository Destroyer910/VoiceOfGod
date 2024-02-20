using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class TextureReplace : MonoBehaviour
{
    Object[] allObjects;
    public Material MatToApply;
    bool fired = false;
    public double delay;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && !fired) {
            fired = true;
            StartCoroutine(fireTextures(delay));
        }
        if(Input.GetKeyUp(KeyCode.E)) {
            fired = false;
        }
    }

    IEnumerator fireTextures(double delay) {
        allObjects = FindObjectsOfType(typeof(MeshRenderer));
        print("Fired!");
        Material[] materials = new Material[allObjects.Length];
        int index = 0;
        foreach (Object obj in allObjects)
        {
            if(obj.GetComponent<MeshRenderer>() != null) {
                materials[index] = obj.GetComponent<MeshRenderer>().material;
                // obj.GetComponent<MeshRenderer>().material = MatToApply;
                if (!obj.GetComponent<AnimGif>())
                    obj.AddComponent<AnimGif>();
            }
            index++;
        }
        index = 0;
        yield return new WaitForSeconds((float)delay);
        foreach (Object obj in allObjects) {
            if(obj.GetComponent<MeshRenderer>() != null) {
                Destroy(obj.GetComponent<AnimGif>());
                obj.GetComponent<MeshRenderer>().material = materials[index];
            }
            index++;
        }
    }   
}
