using System;

namespace Pocos
{
    public partial class app_axopen_integrations_hwcTwinController
    {
        public SandboxContext sandbox { get; set; } = new SandboxContext();
        public DocumentationContext documentation { get; set; } = new DocumentationContext();
        public AXOpen.S71500.Rtc _rtc { get; set; } = new AXOpen.S71500.Rtc();
    }
}