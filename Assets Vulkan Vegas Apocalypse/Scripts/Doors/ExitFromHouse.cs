using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitFromHouse : MonoBehaviour
{
    [SerializeField] private int _sceneIndexForOneLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(_sceneIndexForOneLevel);
    }
}
