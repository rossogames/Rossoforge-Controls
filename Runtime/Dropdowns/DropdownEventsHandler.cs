using TMPro;
using UnityEngine;

namespace Rossoforge.Controls.Dropdowns
{
    [RequireComponent(typeof(TMP_Dropdown))]
    public abstract class DropdownEventsHandler<T> : MonoBehaviour where T : DropdownEventsHandler<T>
    {
        private IDropdownValueChangedListener<T> _valueChangedListener;

        public TMP_Dropdown Dropdown { get; private set; }
        public int Value
        {
            get => Dropdown.value;
            set => Dropdown.value = value;
        }

        protected virtual void Awake()
        {
            Dropdown = GetComponent<TMP_Dropdown>();
            _valueChangedListener = GetComponentInParent<IDropdownValueChangedListener<T>>(true);
        }

        protected virtual void OnEnable()
        {
            Dropdown.onValueChanged.AddListener(OnValueChanged);
        }

        protected virtual void OnDisable()
        {
            Dropdown.onValueChanged.RemoveListener(OnValueChanged);
        }

        private void OnValueChanged(int value)
        {
            var eventArg = new DropdownEventArg<T>((T)this, value);
            _valueChangedListener?.OnValueChanged(eventArg);
        }
    }
}
