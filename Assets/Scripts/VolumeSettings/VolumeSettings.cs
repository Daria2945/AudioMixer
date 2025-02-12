using UnityEngine;
using UnityEngine.Audio;

public abstract class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    
    protected void SetVolume(string parameterAudioMixer, float volume)
    {
        float value = Mathf.Log10(volume) * 20;

        _audioMixer.SetFloat(parameterAudioMixer, value);
    }
}