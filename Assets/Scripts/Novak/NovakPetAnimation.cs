using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Novak
{
    public class NovakPetAnimation
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private uint _cooldown = 0;

        public NovakPetAnimation(Animator animator, Novak novak)
        {
            _animator = animator;
            novak.OnUpdate += Update;
        }

        public bool TryPet()
        {
            if (_cooldown == 0)
            {
                _animator.Play("Pet");
                _cooldown = 40;
                return true;
            }

            return false;
        }

        public void Update()
        {
            if (_cooldown != 0)
                _cooldown -= 1;
        }

    }
}
