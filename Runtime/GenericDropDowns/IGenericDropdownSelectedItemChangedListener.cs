namespace Rossoforge.Controls.GenericDropDowns
{
    public interface IGenericDropdownSelectedItemChangedListener<T, R> where T : GenericDropdownEventsHandler<T, R>
    {
        void OnSelectedItemChanged(GenericDropdownEventArg<T, R> eventArg);
    }
}
