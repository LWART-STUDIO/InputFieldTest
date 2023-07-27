using TMPro;
using UnityEngine;
[RequireComponent(typeof(TMP_Text))]
public class TextLoader : MonoBehaviour
{
    private const string SAVE_KEY = "InputKey";
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        if(!PlayerPrefs.HasKey(SAVE_KEY))
            return;
        _text.SetText(PlayerPrefs.GetString(SAVE_KEY));
    }
}
