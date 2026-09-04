using UnityEngine;
using UnityEngine.UI;

namespace Rossoforge.Controls.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonEventsHandler<T> : MonoBehaviour where T : ButtonEventsHandler<T>
    {
        private IButtonClickListener<T> _clickListener;

        public Button Button { get; private set; }

        protected virtual void Awake()
        {
            Button = GetComponent<Button>();
            _clickListener = GetComponentInParent<IButtonClickListener<T>>(true);
        }

        protected virtual void OnEnable()
        {
            Button.onClick.AddListener(OnClick);
        }

        protected virtual void OnDisable()
        {
            Button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            var eventArg = new ButtonEventArg<T>((T)this);
            _clickListener?.OnClick(eventArg);
        }
    }
}
