using System;
using TMPro;
using UnityEngine;
[RequireComponent(typeof(TMP_InputField))]
public class InputFieldSaver : MonoBehaviour
{
    private const string SAVE_KEY = "InputKey";
    private TMP_InputField _inputField;

    private void Awake()
    {
        _inputField = GetComponent<TMP_InputField>();
        Load();
       TMP_InputField.SubmitEvent submitEvent = new TMP_InputField.SubmitEvent();
       submitEvent.AddListener(Save);
        _inputField.onEndEdit = submitEvent;
    }

    private void Save(string text)
    {
        PlayerPrefs.SetString(SAVE_KEY,text);
        PlayerPrefs.Save();
    }

    private void Load()
    {
        if(!PlayerPrefs.HasKey(SAVE_KEY))
            return;
        _inputField.SetTextWithoutNotify(PlayerPrefs.GetString(SAVE_KEY));
    }
}
