using System;

namespace TestTaskFromDevelopmentSystems.Plugins
{
    internal class PowPlugin : IPlugin
    {
        public string PluginName => nameof(PowPlugin);

        public string Version => "1.0";

        public object Image => "img obj";

        public string Description => "This plugin provides pow operation. See docs for more info";

        /// <summary>
        /// Returns pow for arguments
        /// </summary>
        /// <param name="input1">first number</param>
        /// <param name="input2">second number</param>
        /// <returns>integer number</returns>
        public int Run(int input1, int input2) => (int)Math.Pow(input1, input2);
    }
}