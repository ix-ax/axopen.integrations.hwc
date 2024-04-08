using System;

namespace Pocos
{
    using AXOpen.Integrations.Hwc;

    public partial class SandboxContext : AXOpen.Core.AxoContext, AXSharp.Connector.IPlain
    {
        public Boolean _manualControl { get; set; }

        public AXOpen.Integrations.Hwc.TemplateComponent _testCyclinder { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent();
        public Boolean _homeSensor { get; set; }

        public Boolean _workSensor { get; set; }

        public Boolean _moveHomeSignal { get; set; }

        public Boolean _moveWorkSignal { get; set; }

        public Byte[] _data { get; set; } = new Byte[1];
        public UInt16 _retvalAventics { get; set; }

        public UInt16 _retvalFesto { get; set; }

        public UInt16 _retvalET200 { get; set; }
    }
}