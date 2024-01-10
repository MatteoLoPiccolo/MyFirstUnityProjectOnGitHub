using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void OnButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}