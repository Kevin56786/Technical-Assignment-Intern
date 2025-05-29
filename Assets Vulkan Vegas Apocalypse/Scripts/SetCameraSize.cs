using UnityEngine;

public class SetCameraSize : MonoBehaviour
{
    [SerializeField] private float _cameraSize = 5f;

    private void Start()
    {
        Camera.main.orthographicSize = _cameraSize;
    }
}
