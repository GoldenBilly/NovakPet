using System;
using UnityEngine;
using UnityEngine.UI;

namespace Novak
{
    [RequireComponent(typeof(Text))]
    public class Score : MonoBehaviour
    {
        [SerializeField] private long _score;
        [SerializeField] private Text _textScore;
        public long GetScore { get => _score; }

        public Score(Text textScore)
        {
            _textScore = textScore;
        }

        public void AddScore(UInt64 score)
        {
            _score += (long)score;
            _textScore.text = $"{_score}";
        }

        public void Start()
        {
            _textScore = GetComponent<Text>();
        }
    }
}
