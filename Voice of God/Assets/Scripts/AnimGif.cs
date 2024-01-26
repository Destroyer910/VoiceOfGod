using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class AnimGif : MonoBehaviour {
    [SerializeField] private  float fps = 10.0f;
    Texture2D[] frames = new Texture2D[38];
    private Material mat;

    void Start () {
        mat = gameObject.GetComponent<MeshRenderer>().material;
        frames[0] = Resources.Load("frame_00_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[1] = Resources.Load("frame_01_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[2] = Resources.Load("frame_02_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[3] = Resources.Load("frame_03_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[4] = Resources.Load("frame_04_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[5] = Resources.Load("frame_05_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[6] = Resources.Load("frame_06_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[7] = Resources.Load("frame_07_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[8] = Resources.Load("frame_08_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[9] = Resources.Load("frame_09_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[10] = Resources.Load("frame_10_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[11] = Resources.Load("frame_12_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[12] = Resources.Load("frame_13_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[13] = Resources.Load("frame_14_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[14] = Resources.Load("frame_11_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[15] = Resources.Load("frame_15_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[16] = Resources.Load("frame_16_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[17] = Resources.Load("frame_17_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[18] = Resources.Load("frame_18_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[19] = Resources.Load("frame_19_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[20] = Resources.Load("frame_20_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[21] = Resources.Load("frame_21_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[22] = Resources.Load("frame_22_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[23] = Resources.Load("frame_23_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[24] = Resources.Load("frame_24_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[25] = Resources.Load("frame_25_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[26] = Resources.Load("frame_26_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[27] = Resources.Load("frame_27_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[28] = Resources.Load("frame_28_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[29] = Resources.Load("frame_29_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[30] = Resources.Load("frame_30_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[31] = Resources.Load("frame_31_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[32] = Resources.Load("frame_32_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[33] = Resources.Load("frame_33_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[34] = Resources.Load("frame_34_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[35] = Resources.Load("frame_35_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[36] = Resources.Load("frame_36_delay-0.06s", typeof(Texture2D)) as Texture2D;
        frames[37] = Resources.Load("frame_37_delay-0.06s", typeof(Texture2D)) as Texture2D;
        mat = GetComponent<Renderer> ().material;
    }

    void Update () {
        int index = (int)(Time.time * fps);
        index = index % frames.Length;
        // gameObject.GetComponent<MeshRenderer>().material = frames[index];
    }
}