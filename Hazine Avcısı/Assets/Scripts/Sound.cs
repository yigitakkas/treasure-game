using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    public AudioMixer mixer;

    public void setLevel(float SliderValue)
    {
        mixer.SetFloat("MusicVol",Mathf.Log10(SliderValue)*20);
    }
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
