using Rossoforge.Controls.Buttons;
using Rossoforge.Controls.Dropdowns;
using Rossoforge.Controls.GenericDropDowns;
using Rossoforge.Controls.InputFields;
using Rossoforge.Controls.ProgressBars;
using Rossoforge.Controls.Sliders;
using Rossoforge.Controls.Switches;
using Rossoforge.Controls.Toggles;
using UnityEngine;

namespace Rossoforge.Controls.Samples.EventHandlerDemo
{
    public class DemoEventListeners : MonoBehaviour,
        IButtonClickListener<ButtonTest>,
        ISwitchValueChangedListener<SwitchTest>,
        IToggleValueChangedListener<ToggleTest>,
        ISliderValueChangedListener<SliderTest>,
        IInputFieldValueChangedListener<InputFieldTest>,
        IInputFieldEndEditListener<InputFieldTest>,
        IInputFieldOnSelectListener<InputFieldTest>,
        IInputFieldOnDeselectListener<InputFieldTest>,
        IDropdownValueChangedListener<DropdownTest>,
        IGenericDropdownSelectedItemChangedListener<GenericDropdownTest, Person>,
        IProgressBarValueChangedListener<ProgressBarTest>
    {
        public void OnClick(ButtonEventArg<ButtonTest> eventArg)
        {
            Debug.Log($"Button {eventArg.Button.name} clicked!");
        }

        public void OnValueChanged(SwitchEventArg<SwitchTest> eventArg)
        {
            Debug.Log($"Switch Test changed to: {eventArg.IsOn}");
        }

        public void OnValueChanged(ToggleEventArg<ToggleTest> eventArg)
        {
            Debug.Log($"Toggle Test changed to: {eventArg.IsOn}");
        }

        public void OnValueChanged(SliderEventArg<SliderTest> eventArg)
        {
            Debug.Log($"Slider Test changed to: {eventArg.Value}");
        }

        public void OnValueChanged(InputFieldEventArg<InputFieldTest> eventArg)
        {
            Debug.Log($"Input Field Test changed to: {eventArg.Text}");
        }

        public void OnEndEdit(InputFieldEventArg<InputFieldTest> arg)
        {
            Debug.Log("Input Field Test end edit");
        }

        public void OnSelect(InputFieldEventArg<InputFieldTest> eventArg)
        {
            Debug.Log("Input Field Test selected");
        }

        public void OnDeselect(InputFieldEventArg<InputFieldTest> eventArg)
        {
            Debug.Log("Input Field Test deselected");
        }

        public void OnValueChanged(DropdownEventArg<DropdownTest> eventArg)
        {
            Debug.Log($"Dropdown Test changed to: {eventArg.SelectedIndex}");
        }

        public void OnSelectedItemChanged(GenericDropdownEventArg<GenericDropdownTest, Person> eventArg)
        {
            Debug.Log($"Selected person: {eventArg.SelectedItem.Name}, Age: {eventArg.SelectedItem.Age}");
        }

        public void OnValueChanged(ProgressBarEventArg<ProgressBarTest> eventArg)
        {
            Debug.Log($"Progress Bar Test changed to: {eventArg.Value}");
        }
    }
}