using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class SceneLoader : MonoBehaviour
{
   private const string SCENE_NAME = "1";
   private Button _button;
   private void Awake()
   {
      _button = GetComponent<Button>();
      _button.onClick.AddListener(LoadScene);
   }

   private void LoadScene()
   {
      SceneManager.LoadScene(SCENE_NAME);
   }
   
}
