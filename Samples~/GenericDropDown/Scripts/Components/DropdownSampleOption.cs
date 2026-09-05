using UnityEngine;

namespace Rossoforge.Controls.Samples.GenericDropDownDemo
{
    [CreateAssetMenu(fileName = nameof(DropdownSampleOption), menuName = "MyGame/Controls/DropdownSampleOption")]
    public class DropdownSampleOption : ScriptableObject
    {
        public int Id;
        public string Label;
        public Sprite Icon;
    }
}