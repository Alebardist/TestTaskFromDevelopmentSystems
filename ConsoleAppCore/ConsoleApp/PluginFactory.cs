using System;

namespace TestTaskFromDevelopmentSystems
{
    internal class PluginFactory : IPluginFactory
    {
        public int PluginsCount => GetPluginNames.Length;

        public string[] GetPluginNames => new[] { nameof(Plugins.PowPlugin) };

        /// <summary>
        /// Method to get plugin by its name
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns cref="IPlugin">instance</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="TypeLoadException"></exception>
        /// <exception cref="Exception"></exception>
        public IPlugin GetPlugin(string pluginName)
        {
            if (string.IsNullOrEmpty(pluginName))
            {
                Console.WriteLine("Error, plugin name Is Null Or Empty!");
                throw new ArgumentOutOfRangeException();
            }

            IPlugin plugin;
            try
            {
                var type = Type.GetType($"TestTaskFromDevelopmentSystems.Plugin.{pluginName}", throwOnError: true, ignoreCase: false);

                plugin = (IPlugin)Activator.CreateInstance(type);
            }
            catch (TypeLoadException)
            {
                Console.WriteLine("Error, check the plugin name!");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error!");
                throw;
            }

            return plugin;
        }
    }
}