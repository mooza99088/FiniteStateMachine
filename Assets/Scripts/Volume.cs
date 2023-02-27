using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{

    public float volume;

    [SerializeField] Text volumeText;

    [SerializeField] Slider volSlider;

    void Start()
    {
        volume = 200f;

        volumeText.text = "volume = " + volume + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeSlide()
    {
        volume = volSlider.value;
        volumeText.text = "Volume = " + volume + "%";
    }
}
