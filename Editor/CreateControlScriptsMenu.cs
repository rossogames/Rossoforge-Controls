using UnityEditor;

namespace Rossoforge.UI.Controls.Editor
{
    public static class CreateControlScriptsMenu
    {
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Button", false)]
        public static void CreateButton()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/ButtonEventsHandlerTemplate.txt",
                "NewButton.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Dropdown", false)]
        public static void CreateDropdown()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/DropdownEventsHandlerTemplate.txt",
                "NewDropdown.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Generic Dropdown", false)]
        public static void CreateGenericDropdown()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/GenericDropdownEventsHandlerTemplate.txt",
                "NewGenericDropdown.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Input Field", false)]
        public static void CreateInputField()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/InputFieldEventsHandlerTemplate.txt",
                "NewInputField.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Progress Bar", false)]
        public static void CreateProgressBar()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/ProgressBarEventsHandlerTemplate.txt",
                "NewProgressBar.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Slider", false)]
        public static void CreateSlider()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/SliderEventsHandlerTemplate.txt",
                "NewSlider.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Switch", false)]
        public static void CreateSwitch()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/SwitchEventsHandlerTemplate.txt",
                "NewSwitch.cs"
            );
        }
        [MenuItem("Assets/Create/Rossoforge/UI/Controls/Toggle", false)]
        public static void CreateToggle()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(
                "Packages/com.rossogames.rossoforge-ui-controls/Editor/ScriptTemplates/ToggleEventsHandlerTemplate.txt",
                "NewToggle.cs"
            );
        }
    }
}
