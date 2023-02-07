using System;
using UnityEngine;
using UnityEngine.UI;

namespace Novak
{
    [RequireComponent(typeof(Text))]
    public class Score : MonoBehaviour, IScore
    {
        [SerializeField] private ScoreBehaviour _score;
        [SerializeField] private Text _textScore;
        public ScoreBehaviour GetScoreBehaviour { get => _score; }

        private void Start()
        {
            _textScore = GetComponent<Text>();
            _score = new ScoreBehaviour();
            _score.OnScoreUpdate += OnUpdateScore;
        }

        private void OnUpdateScore(uint addedScore)
        {
            _textScore.text = $"{_score.GetScore}";
        }

        public void AddScore(uint score) => _score.AddScore(score);
    }
}
