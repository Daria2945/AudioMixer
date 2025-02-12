using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MusicButton : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    private Button _button;

    public AudioClip Clip => _clip;

    public event Action<MusicButton> Clicked;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(InvokeClickedEvent);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(InvokeClickedEvent);
    }

    private void InvokeClickedEvent() =>
        Clicked?.Invoke(this);
}