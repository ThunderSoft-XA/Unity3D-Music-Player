using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFreqBands : MonoBehaviour
{
    public AudioSource audioSource;
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];
    public GameObject prefab;
    GameObject[] MusicCube = new GameObject[512];

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        GetAudioSourceSpectrum();
        MakefreqBand();
    }

    void GetAudioSourceSpectrum()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void MakefreqBand()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;         //2^n
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += samples[count] * (count + 1);           //累加2^n以内的频谱数据
                count++;
            }
            average /= count;                                      //求均值
            freqBand[i] = average * 10;                            //均值赋给freqBand
            
            //Debug.Log(freqBand[i]);
        }
    }
}
