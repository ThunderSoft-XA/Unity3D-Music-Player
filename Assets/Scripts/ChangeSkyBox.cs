using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{
    public Material[] mats;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DoChangeSkyBox", 0, 60f);
    }

    void DoChangeSkyBox()
    {
        RenderSettings.skybox = mats[index];
        index++;
        index %= mats.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //
    }
}
