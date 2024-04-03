using System;

namespace Pocos
{
    namespace AXOpen.Integrations.Hwc
    {
        public partial class TemplateComponent_Out : AXSharp.Connector.IPlain
        {
            public AXOpen.Integrations.Hwc.TemplateComponent_Control Control { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent_Control();
        }
    }
}