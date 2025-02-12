using UnityEngine;
using UnityEngine.UI;

public class SetingMasterVolume : VolumeSettings
{
    private const string MasterVolume = "MasterVolume";

    [SerializeField] private Slider _sliderMasterVolume;

    private void Start()
    {
        SetMasterVolume(_sliderMasterVolume.value);
    }

    private void OnEnable()
    {
        _sliderMasterVolume.onValueChanged.AddListener(SetMasterVolume);
    }

    private void OnDisable()
    {
        _sliderMasterVolume.onValueChanged.RemoveListener(SetMasterVolume);
    }

    private void SetMasterVolume(float volume) =>
        SetVolume(MasterVolume, volume);
}