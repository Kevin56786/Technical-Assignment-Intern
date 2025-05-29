using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuLogic : MonoBehaviour
{
    public void ExitInStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
