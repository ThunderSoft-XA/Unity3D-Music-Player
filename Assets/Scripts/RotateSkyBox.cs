using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkyBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float num = RenderSettings.skybox.GetFloat("_Rotation");
        RenderSettings.skybox.SetFloat("_Rotation", num + 0.05f);
    }
}
