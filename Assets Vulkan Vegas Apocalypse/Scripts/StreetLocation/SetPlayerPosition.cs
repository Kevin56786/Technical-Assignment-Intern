using UnityEngine;

public class SetPlayerPosition : MonoBehaviour
{
    [SerializeField] private VectorValue _positionPlayer;
    [SerializeField] private Vector3 _playerSpawnPosition;

    private void Awake()
    {
        _positionPlayer.InitialValue = _playerSpawnPosition;
        Debug.Log(_positionPlayer.InitialValue);
    }
}
