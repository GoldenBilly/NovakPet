using UnityEngine;
using UnityEngine.UI;

namespace Novak
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicBehaviour : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private Slider _slider;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void OnGUI()
        {
            _audioSource.volume = _slider.value;
        }

    }
}
