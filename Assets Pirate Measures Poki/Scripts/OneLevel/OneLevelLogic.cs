using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OneLevelLogic : MonoBehaviour
{
    [SerializeField] private int _sceneIndexForTwoLevel;

    [SerializeField] private InputField _inputField;

    [SerializeField] private GameObject _canvasRightAnswer;
    [SerializeField] private GameObject _canvasWrongAnswer;

    private const int RIGHT_ANSWER = 11;

    private void Start()
    {
        _inputField.Select();
        _inputField.ActivateInputField();
    }

    public void GetTheNumberOfStepsFromTheText()
    {
        try
        {
            int stepCount = Convert.ToInt32(_inputField.text);

            if (stepCount == RIGHT_ANSWER)
            {
                _canvasRightAnswer.SetActive(true);
            }
            else
            {
                _canvasWrongAnswer.SetActive(true);
            }          
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public void WinLevel()
    {
        SceneManager.LoadScene(_sceneIndexForTwoLevel);
    }

    public void LoseLevel()
    {
        _canvasWrongAnswer.SetActive(false);
    }
}
