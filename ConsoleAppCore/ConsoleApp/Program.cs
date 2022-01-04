using System;

using TestTaskFromDevelopmentSystems.Plugins;

namespace TestTaskFromDevelopmentSystems
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pluginRunResult = new PluginFactory().GetPlugin(nameof(PowPlugin)).Run(351, 22);

            Console.WriteLine(pluginRunResult);

            Console.WriteLine("-end");
            Console.Read();
        }
    }
}