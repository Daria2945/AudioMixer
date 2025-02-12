using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingVolumeButton : VolumeSettings
{
    private const string ButtonVolume = "ButtonVolume";

    [SerializeField] private Slider _sliderButtonVolume;

    private void Start()
    {
        SetButtonVolume(_sliderButtonVolume.value);
    }

    private void OnEnable()
    {
        _sliderButtonVolume.onValueChanged.AddListener(SetButtonVolume);
    }

    private void OnDisable()
    {
        _sliderButtonVolume.onValueChanged.RemoveListener(SetButtonVolume);
    }

    private void SetButtonVolume(float volume) =>
        SetVolume(ButtonVolume, volume);
}