
using System.Reflection;
using AXSharp.Connector.Localizations;

namespace app_axopen_integrations_hwc
{
    public sealed class PlcTranslator : Translator
    {
        private static readonly PlcTranslator instance = new PlcTranslator();

        public static PlcTranslator Instance
        {
            get
            {
                return instance;
            }
        }

        private PlcTranslator() 
        {
            var defaultResourceType = Assembly.GetAssembly(typeof(app_axopen_integrations_hwc.PlcTranslator))
                .GetType("app_axopen_integrations_hwc.Resources.PlcStringResources");
            this.SetLocalizationResource(defaultResourceType);
        }
    }
}