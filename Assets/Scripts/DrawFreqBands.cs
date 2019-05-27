using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFreqBands : MonoBehaviour
{
    public int bandNum;
    public float multiplier, startScale;


    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3 (transform.localScale.x, (MakeFreqBands.freqBand[bandNum] * multiplier + startScale), transform.localScale.z);
    }
}
