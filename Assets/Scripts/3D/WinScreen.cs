using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private CanvasGroup _winScreen;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private int _nextSceneIndex;

    private void OnEnable()
    {
        _score.OnScoreUpdate += OnScoreUpdate;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _nextLevelButton.onClick.AddListener(OnNextLevelButtonClick);
    }

    private void OnDisable()
    {
        _score.OnScoreUpdate -= OnScoreUpdate;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _nextLevelButton.onClick.RemoveListener(OnNextLevelButtonClick);
    }

    private void OnScoreUpdate()
    {
        _winScreen.alpha = 1f;
        _winScreen.interactable = true;
    }

    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnNextLevelButtonClick()
    {
        SceneManager.LoadScene(_nextSceneIndex);
    }
}