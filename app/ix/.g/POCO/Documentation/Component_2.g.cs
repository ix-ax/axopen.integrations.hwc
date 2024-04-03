using System;

namespace Pocos
{
    using AXOpen.Core;
    using AXOpen.Integrations.Hwc;

    public partial class Component_2 : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
    {
        public AXOpen.Integrations.Hwc.TemplateComponent ExampleCylinder { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent();
        public Boolean ActivateManualControl { get; set; }

        public Boolean _homeSensor { get; set; }

        public Boolean _workSensor { get; set; }

        public Boolean _moveHomeSignal { get; set; }

        public Boolean _moveWorkSignal { get; set; }

        public AXOpen.Core.AxoSequencer Sequencer { get; set; } = new AXOpen.Core.AxoSequencer();
        public AXOpen.Core.AxoStep[] Steps { get; set; } = new AXOpen.Core.AxoStep[4];
    }
}