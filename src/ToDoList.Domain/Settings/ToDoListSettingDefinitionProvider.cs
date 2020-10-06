using Volo.Abp.Settings;

namespace ToDoList.Settings
{
    public class ToDoListSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ToDoListSettings.MySetting1));
        }
    }
}
