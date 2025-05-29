using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
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

    public void CloseSettings()
    {
        _setActiveSettings.SetActive(false);
    }
}
