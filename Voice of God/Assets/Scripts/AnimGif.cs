using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class AnimGif : MonoBehaviour {
    [SerializeField] private  float fps = 0.02f;
    [SerializeField] Material[] frame;
    int index = 0;

    void Start ()
    {
        frame = new Material[]
        {
            Resources.Load("vert_frame0", typeof(Material)) as Material,
            Resources.Load("vert_frame1", typeof(Material)) as Material,
            Resources.Load("vert_frame2", typeof(Material)) as Material,
            Resources.Load("vert_frame3", typeof(Material)) as Material,
            Resources.Load("vert_frame4", typeof(Material)) as Material,
            Resources.Load("vert_frame5", typeof(Material)) as Material,
            Resources.Load("vert_frame6", typeof(Material)) as Material,
            Resources.Load("vert_frame7", typeof(Material)) as Material
        };
        print(Resources.Load("frame0", typeof(Material)) as Material);
        StartCoroutine(frameCycle());
    }

    IEnumerator frameCycle()
    {
        gameObject.GetComponent<Renderer>().material = frame[index];
        if (index < frame.Length - 1)
        {
            index++;
        } else
        {
            index = 0;
        }
        yield return new WaitForSeconds(fps);
        StartCoroutine(frameCycle());
    }
}