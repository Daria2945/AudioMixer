using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonsSoundSource;
    [SerializeField] private List<MusicButton> _musicButtons = new();

    private void OnEnable()
    {
        foreach (var button in _musicButtons)
            button.Clicked += PlayMusic;
    }

    private void OnDisable()
    {
        foreach (var button in _musicButtons)
            button.Clicked -= PlayMusic;
    }

    private void PlayMusic(MusicButton button)
    {
        _buttonsSoundSource.clip = button.Clip;
        _buttonsSoundSource.Play();
    }
}