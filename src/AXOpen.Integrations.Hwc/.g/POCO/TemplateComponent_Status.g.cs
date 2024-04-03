using System;

namespace Pocos
{
    namespace AXOpen.Integrations.Hwc
    {
        public partial class TemplateComponent_Status : AXSharp.Connector.IPlain
        {
            public Boolean HomeSensor { get; set; }

            public Boolean WorkSensor { get; set; }
        }
    }
}