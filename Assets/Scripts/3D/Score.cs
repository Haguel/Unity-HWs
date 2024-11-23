using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private int _nextSceneIndex;

    private List<Dirt> _dirts;
    private int _scoreValue;

    public event UnityAction OnScoreUpdate;

    private void Start()
    {
        InitializeScore();
    }

    private void OnEnable()
    {
        _player.OnDirtPickUp += SetScore;
    }

    private void OnDisable()
    {
        _player.OnDirtPickUp -= SetScore;
    }

    private void InitializeScore()
    {
        _dirts = new List<Dirt>(FindObjectsOfType<Dirt>());
        _scoreValue = 0;
        UpdateScoreText();
    }

    private void SetScore()
    {
        _scoreValue++;

        var activeDirts = _dirts.FindAll(dirt => dirt.gameObject.activeSelf);

        if (activeDirts.Count == 0)
        {
            OnScoreUpdate?.Invoke();
            _scoreText.gameObject.SetActive(false);
        }
        else
        {
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        _scoreText.text = $"Score: {_scoreValue}";
    }
}