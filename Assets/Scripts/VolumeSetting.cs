using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    [SerializeField] private string _nameParameterMixer;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        SetVolume(_slider.value);
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetVolume);
    }

    protected void SetVolume(float volume)
    {
        float value = Mathf.Log10(volume) * 20;

        _audioMixer.SetFloat(_nameParameterMixer, value);
    }
}