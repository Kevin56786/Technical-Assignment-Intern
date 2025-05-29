using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject _closeSettings;

    public void ExitSettings()
    {
        _closeSettings.SetActive(false);
    }
}
