using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private int _sceneIndexForOneLevel;

    [SerializeField] private GameObject _setActiveSettings;

    public void StartGame()
    {
        SceneManager.LoadScene(_sceneIndexForOneLevel);
    }

    public void OpenSettings()
    {
        _setActiveSettings.SetActive(true);
    }

}
