using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    private const string OverallVolume = "OverallVolume";
    private const string ButtonVolume = "ButtonVolume";
    private const string BackgroundVolume = "BackgroundVolume";

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _sliderOverallVolume;
    [SerializeField] private Slider _sliderButtonVolume;
    [SerializeField] private Slider _backgriundMusicSlider;

    private void Start()
    {
        SetOverallVolume(_sliderOverallVolume.value);
        SetButtonVolume(_sliderButtonVolume.value);
        SetBackgroundVolume(_backgriundMusicSlider.value);
    }

    private void OnEnable()
    {
        _sliderOverallVolume.onValueChanged.AddListener(SetOverallVolume);
        _sliderButtonVolume.onValueChanged.AddListener(SetButtonVolume);
        _backgriundMusicSlider.onValueChanged.AddListener(SetBackgroundVolume);
    }

    private void OnDisable()
    {
        _sliderOverallVolume.onValueChanged.RemoveListener(SetOverallVolume);
        _sliderButtonVolume.onValueChanged.RemoveListener(SetButtonVolume);
        _backgriundMusicSlider.onValueChanged.RemoveListener(SetBackgroundVolume);
    }

    private void SetOverallVolume(float volume) => _audioMixer.SetFloat(OverallVolume, Mathf.Log10(volume) * 20);

    private void SetButtonVolume(float volume) => _audioMixer.SetFloat(ButtonVolume, Mathf.Log10(volume) * 20);

    private void SetBackgroundVolume(float volume) => _audioMixer.SetFloat(BackgroundVolume, Mathf.Log10(volume) * 20);
}