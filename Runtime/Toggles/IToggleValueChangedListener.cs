namespace Rossoforge.Controls.Toggles
{
    public interface IToggleValueChangedListener<T> where T : ToggleEventsHandler<T>
    {
        void OnValueChanged(ToggleEventArg<T> eventArg);
    }
}
