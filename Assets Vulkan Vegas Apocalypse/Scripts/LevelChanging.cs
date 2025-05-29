using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;



public class LevelChanging : MonoBehaviour
{
    [System.Serializable]
    public class DoorScenePair
    {
        public int DoorID;
        public int SceneBuildIndex;
    }

    [SerializeField] private DoorScenePair[] _doorSceneMappings;
    [SerializeField] private VectorValue _playerPositionStorage;

    [SerializeField] private int _currentActiveDoorID = -1;

    private void OnEnable()
    {
        ButtonTrigger.OnDoorEntered.AddListener(SetActiveDoor);
        ButtonTrigger.OnDoorExited.AddListener(ClearActiveDoor);
    }

    private void OnDisable()
    {
        ButtonTrigger.OnDoorEntered.RemoveListener(SetActiveDoor);
        ButtonTrigger.OnDoorExited.RemoveListener(ClearActiveDoor);
    }

    private void SetActiveDoor(int doorID, Vector3 spawnPosition)
    {
        _currentActiveDoorID = doorID;
        _playerPositionStorage.InitialValue = spawnPosition;
    }

    private void ClearActiveDoor()
    {
        _currentActiveDoorID = -1;
    }

    public void TryLoadScene()
    {
        if (_currentActiveDoorID == -1)
        {
            Debug.LogWarning("No active door available");
            return;
        }

        foreach (var mapping in _doorSceneMappings)
        {
            if (mapping.DoorID == _currentActiveDoorID)
            {
                SceneManager.LoadScene(mapping.SceneBuildIndex);
                return;
            }
        }

        Debug.LogError($"No scene configured for door ID: {_currentActiveDoorID}");
    }
}
