using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Exit : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Application.Quit();
    }
}
