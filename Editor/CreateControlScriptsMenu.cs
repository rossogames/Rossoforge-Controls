using UnityEditor;

namespace Rossoforge.UI.Controls.Editor
{
    public static class CreateControlScriptsMenu
    {
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Button Handler", false)]
        public static void CreateButton()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/ButtonEventsHandlerTemplate.txt",
                "NewButtonHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Dropdown Handler", false)]
        public static void CreateDropdown()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/DropdownEventsHandlerTemplate.txt",
                "NewDropdownHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Generic Dropdown Handler", false)]
        public static void CreateGenericDropdown()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/GenericDropdownEventsHandlerTemplate.txt",
                "NewGenericDropdownHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Input Field Handler", false)]
        public static void CreateInputField()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/InputFieldEventsHandlerTemplate.txt",
                "NewInputFieldHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Progress Bar Handler", false)]
        public static void CreateProgressBar()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/ProgressBarEventsHandlerTemplate.txt",
                "NewProgressBarHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Slider Handler", false)]
        public static void CreateSlider()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/SliderEventsHandlerTemplate.txt",
                "NewSliderHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Switch Handler", false)]
        public static void CreateSwitch()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/SwitchEventsHandlerTemplate.txt",
                "NewSwitchHandler.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/Scripts/Controls/Toggle Handler", false)]
        public static void CreateToggle()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/ToggleEventsHandlerTemplate.txt",
                "NewToggleHandler.cs"
            );
        }
    }
}
