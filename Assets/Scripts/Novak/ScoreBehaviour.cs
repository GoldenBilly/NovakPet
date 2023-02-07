using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Novak
{
    public delegate void OnScoreUpdateDelegate(uint addedScore);

    public class ScoreBehaviour : IScore
    {
        [SerializeField] private ulong _score;
        public long GetScore { get => Convert.ToInt64(_score); }
        public event OnScoreUpdateDelegate OnScoreUpdate;

        public void AddScore(uint score)
        {
            _score += score;
            OnScoreUpdate?.Invoke(score);
        }
    }
}
