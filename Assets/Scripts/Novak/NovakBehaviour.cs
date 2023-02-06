using UnityEngine;

namespace Novak
{
    public class NovakBehaviour
    {
        [SerializeField] private Score _score;
        [SerializeField] private NovakPetAnimation _novakPetAnimation;

        public NovakBehaviour(Score score, Animator animator, Novak novak) {
            _score = score;
            _novakPetAnimation = new NovakPetAnimation(animator, novak);
        }
        
        public bool TryPet()
        {
            bool isPetted = _novakPetAnimation.TryPet();
            if (isPetted)
            {
                _score.AddScore(1);
                return true;
            }

            return false;
        }
    }
}

