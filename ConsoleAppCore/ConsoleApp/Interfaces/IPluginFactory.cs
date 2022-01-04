namespace TestTaskFromDevelopmentSystems
{
    internal interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }

        IPlugin GetPlugin(string pluginName);
    }
}