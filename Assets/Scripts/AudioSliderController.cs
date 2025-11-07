using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSliderController : MonoBehaviour
{
    [SerializeField] private AudioMixer Mixer;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private AudioMixMode mixMode;

    public void OCnChangeSlider(float value) {
        valueText.SetText($"{value.ToString("N2")}");

        switch ( mixMode )
        {
            case AudioMixMode.LogarithmicMixerVolume:
                Mixer.SetFloat("Volume", Mathf.Log10(value) * 20);
            break;

        }
    }

    public enum AudioMixMode { 
        LinearAudioSourceVolume, 
        LinearMixerVolume, 
        LogarithmicMixerVolume
    }
}
