using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MusicButton : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioSource _buttonsSoundSource;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(PlayMusic);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlayMusic);
    }

    private void PlayMusic()
    {
        _buttonsSoundSource.PlayOneShot(_clip);
    }
}