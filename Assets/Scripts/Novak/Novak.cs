using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

namespace Novak
{
    public delegate void OnUpdateDelegate();

    [RequireComponent(typeof(Animator))]
    public class Novak : MonoBehaviour
    {
        [SerializeField] private Score _score;
        [SerializeField] private NovakBehaviour _novakBehaviour;
        public event OnUpdateDelegate OnUpdate;

        private void Start()
        {
            Animator animator = GetComponent<Animator>();
            _novakBehaviour = new NovakBehaviour(_score, animator, this);

        }

        private void OnMouseDown()
        {
            _novakBehaviour.TryPet();
        }
        
        private void OnGUI()
        {
            OnUpdate?.Invoke();
            if (Input.GetKey(KeyCode.Escape))
                Application.Quit();
        }
    }
}
