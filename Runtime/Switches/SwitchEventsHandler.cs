using UnityEngine;

namespace Rossoforge.Controls.Switches
{
    [RequireComponent(typeof(Switch))]
    public abstract class SwitchEventsHandler<T> : MonoBehaviour where T : SwitchEventsHandler<T>
    {
        private ISwitchValueChangedListener<T> _valueChangedListener;

        public Switch Switch { get; private set; }
        public bool Value
        {
            get => Switch.IsOn;
            set => Switch.IsOn = value;
        }

        protected virtual void Awake()
        {
            Switch = GetComponent<Switch>();
            _valueChangedListener = GetComponentInParent<ISwitchValueChangedListener<T>>(true);
        }

        protected virtual void OnEnable()
        {
            Switch.onValueChanged.AddListener(OnValueChanged);
        }

        protected virtual void OnDisable()
        {
            Switch.onValueChanged.RemoveListener(OnValueChanged);
        }

        private void OnValueChanged(bool isOn)
        {
            var eventArg = new SwitchEventArg<T>((T)this, isOn);
            _valueChangedListener?.OnValueChanged(eventArg);
        }
    }
}
