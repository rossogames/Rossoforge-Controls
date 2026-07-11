using UnityEngine;
using UnityEngine.UI;

namespace Rossoforge.UI.Controls.Sliders
{
    [RequireComponent(typeof(Slider))]
    public abstract class SliderEventsHandler<T> : MonoBehaviour where T : SliderEventsHandler<T>
    {
        private ISliderValueChangedListener<T> _valueChangedListener;

        public Slider Slider { get; private set; }
        public float Value
        {
            get => Slider.value;
            set => Slider.value = value;
        }

        protected virtual void Awake()
        {
            Slider = GetComponent<Slider>();
            _valueChangedListener = GetComponentInParent<ISliderValueChangedListener<T>>(true);
        }

        protected virtual void OnEnable()
        {
            Slider.onValueChanged.AddListener(OnValueChanged);
        }

        protected virtual void OnDisable()
        {
            Slider.onValueChanged.RemoveListener(OnValueChanged);
        }

        private void OnValueChanged(float value)
        {
            var eventArg = new SliderEventArg<T>((T)this, value);
            _valueChangedListener?.OnValueChanged(eventArg);
        }
    }
}
