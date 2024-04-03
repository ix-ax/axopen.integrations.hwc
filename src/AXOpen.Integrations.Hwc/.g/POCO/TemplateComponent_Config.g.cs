using System;

namespace Pocos
{
    namespace AXOpen.Integrations.Hwc
    {
        public partial class TemplateComponent_Config : AXSharp.Connector.IPlain
        {
            public TimeSpan InfoTime { get; set; } = default(TimeSpan);
            public TimeSpan ErrorTime { get; set; } = default(TimeSpan);
        }
    }
}