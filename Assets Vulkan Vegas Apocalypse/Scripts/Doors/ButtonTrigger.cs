using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DoorTriggerEvent : UnityEvent<int, Vector3> { }

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _highlightFrame;

    [SerializeField] private int _doorID;
    [SerializeField] private Vector3 _playerSpawnPosition;

    public static DoorTriggerEvent OnDoorEntered = new DoorTriggerEvent();
    public static UnityEvent OnDoorExited = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleDoorVisuals(true);
            OnDoorEntered?.Invoke(_doorID, _playerSpawnPosition);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleDoorVisuals(false);
            OnDoorExited?.Invoke();
        }
    }

    private void ToggleDoorVisuals(bool state)
    {
        if (_animator != null)
            _animator.SetBool("Active", state);

        if (_highlightFrame != null)
            _highlightFrame.SetActive(state);
    }
}
