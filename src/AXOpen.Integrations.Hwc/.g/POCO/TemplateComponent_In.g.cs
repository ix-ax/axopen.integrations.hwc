using System;

namespace Pocos
{
    namespace AXOpen.Integrations.Hwc
    {
        public partial class TemplateComponent_In : AXSharp.Connector.IPlain
        {
            public AXOpen.Integrations.Hwc.TemplateComponent_Status Status { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent_Status();
        }
    }
}