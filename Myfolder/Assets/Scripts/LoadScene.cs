using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    [SerializeField] Button firstSceneButton;
    [SerializeField] Button secondSceneButton;
    [SerializeField] Button thirdSceneButton;

    [SerializeField] string firstScene;
    [SerializeField] string secondScene;
    [SerializeField] string thirdScene;

    void Start()
    {
        firstSceneButton.onClick.AddListener(() => OnButtonClick(firstScene));
        secondSceneButton.onClick.AddListener(() => OnButtonClick(secondScene));
        thirdSceneButton.onClick.AddListener(() => OnButtonClick(thirdScene));
    }

    void OnButtonClick(string sceneName)
    {
        Debug.Log("Button clicked!");
        SceneManager.LoadScene(sceneName);
    }
}