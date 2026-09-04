using UnityEngine;

namespace Rossoforge.Controls.ProgressBars
{
    [RequireComponent(typeof(ProgressBar))]
    public abstract class ProgressBarEventsHandler<T> : MonoBehaviour where T : ProgressBarEventsHandler<T>
    {
        private IProgressBarValueChangedListener<T> _valueChangedListener;

        public ProgressBar ProgressBar { get; private set; }
        public float Value
        {
            get => ProgressBar.value;
            set => ProgressBar.value = value;
        }

        protected virtual void Awake()
        {
            ProgressBar = GetComponent<ProgressBar>();
            _valueChangedListener = GetComponentInParent<IProgressBarValueChangedListener<T>>(true);
        }

        protected virtual void OnEnable()
        {
            ProgressBar.onValueChanged.AddListener(OnValueChanged);
        }

        protected virtual void OnDisable()
        {
            ProgressBar.onValueChanged.RemoveListener(OnValueChanged);
        }

        private void OnValueChanged(float value)
        {
            var eventArg = new ProgressBarEventArg<T>((T)this, value);
            _valueChangedListener?.OnValueChanged(eventArg);
        }
    }
}
