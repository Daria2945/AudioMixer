using UnityEngine;
using UnityEngine.UI;

public class AudioSwich : MonoBehaviour
{
    [SerializeField] private Button _button;

    private bool _isMute;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonPress);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonPress);
    }

    private void OnButtonPress()
    {
        if (_isMute)
        {
            _isMute = false;
            AudioListener.pause = false;
        }
        else
        {
            _isMute = true;
            AudioListener.pause = true;
        }
    }
}