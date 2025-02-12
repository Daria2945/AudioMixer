using UnityEngine;
using UnityEngine.UI;

public class SettingBackgroundVolume : VolumeSettings
{
    private const string BackgroundVolume = "BackgroundVolume";

    [SerializeField] private Slider _backgriundMusicSlider;

    private void Start()
    {
        SetBackgroundVolume(_backgriundMusicSlider.value);
    }

    private void OnEnable()
    {
        _backgriundMusicSlider.onValueChanged.AddListener(SetBackgroundVolume);
    }

    private void OnDisable()
    {
        _backgriundMusicSlider.onValueChanged.RemoveListener(SetBackgroundVolume);
    }

    private void SetBackgroundVolume(float volume) =>
        SetVolume(BackgroundVolume, volume);
}