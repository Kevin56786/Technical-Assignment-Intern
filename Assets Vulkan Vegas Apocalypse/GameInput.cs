using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance {  get; private set; }

    private PlayerControl _playerControl;

    private void Awake()
    {
        Instance = this;

        _playerControl = new PlayerControl();
        _playerControl.Enable();
    }

    public Vector2 GetMovementVector()
    {
        Vector2 inputVector = _playerControl.Player.Move.ReadValue<Vector2>();

        return inputVector;
    }
}
