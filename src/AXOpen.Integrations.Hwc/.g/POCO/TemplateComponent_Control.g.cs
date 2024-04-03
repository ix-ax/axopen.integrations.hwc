using System;

namespace Pocos
{
    namespace AXOpen.Integrations.Hwc
    {
        public partial class TemplateComponent_Control : AXSharp.Connector.IPlain
        {
            public Boolean MoveHomeSignal { get; set; }

            public Boolean MoveWorkSignal { get; set; }
        }
    }
}