using UnityEngine;
using UnityEngine.UI;

public class AudioSwich : MonoBehaviour
{
    [SerializeField] private Button _button;

    private bool _isMute;

    private void OnEnable()
    {
        _button.onClick.AddListener(SetActivity);
    }

    private void OnDisable()
    {
        _button.onClick.AddListener(SetActivity);
    }

    private void SetActivity()
    {
        if (_isMute)
        {
            PlaySound();
        }
        else
        {
            StopSound();
        }
    }

    private void PlaySound()
    {
        _isMute = false;
        AudioListener.pause = false;
    }

    private void StopSound()
    {
        _isMute = true;
        AudioListener.pause = true;
    }
}