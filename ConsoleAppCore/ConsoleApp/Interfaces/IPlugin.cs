namespace TestTaskFromDevelopmentSystems
{
    internal interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        object Image { get; }
        string Description { get; }

        int Run(int input1, int input2);
    }
}