using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(Button))]
    public class VRButton : MonoBehaviour
    {
        [SerializeField] Color _selectedColor = new Color(223, 255, 232);
        [HideInInspector] public UnityEvent eventCLickAnim;
        [HideInInspector] public UnityEvent eventCLick;

        public UnityEvent eventInside;
        public UnityEvent eventOutside;
        private Image _image;
        private Color _oldColor;
        private Button _button;

        private void Start()
        {
            // copy on click events from button
            _button = GetComponent<Button>();
            eventCLickAnim = _button.onClick;

            _image = GetComponent<Image>();
        }

        public void AnimationComplete()
        {
            eventCLickAnim.Invoke();
        }

        public void OnSelected()
        {
            _oldColor = _image.color;
            _image.color = _selectedColor;
        }

        public void OnDeselected()
        {
            _image.color = _oldColor;
        }
    }
}
