using System;

namespace Pocos
{
    using AXOpen.Core;
    using AXOpen.Messaging;
    using AXOpen.Messaging.Static;

    namespace AXOpen.Integrations.Hwc
    {
        public partial class TemplateComponent : AXOpen.Core.AxoComponent, AXSharp.Connector.IPlain
        {
            public AXOpen.Core.AxoTask MoveToWorkTask { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask MoveToHomeTask { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask RestoreTask { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask StopTask { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_10steps_1 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_10steps_2 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_10steps_3 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_10steps_4 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_10steps_5 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_20steps_1 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_20steps_2 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_20steps_3 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_20steps_4 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask TemplateTask_20steps_5 { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Integrations.Hwc.TemplateComponent_Config Config { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent_Config();
            public AXOpen.Integrations.Hwc.TemplateComponent_Component_Status Status { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent_Component_Status();
            public AXOpen.Messaging.Static.AxoMessenger Messenger { get; set; } = new AXOpen.Messaging.Static.AxoMessenger();
            public AXOpen.Messaging.Static.AxoMessenger TaskMessenger { get; set; } = new AXOpen.Messaging.Static.AxoMessenger();
            public AXOpen.Integrations.Hwc.TemplateComponent_In Inputs { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent_In();
            public AXOpen.Integrations.Hwc.TemplateComponent_Out Outputs { get; set; } = new AXOpen.Integrations.Hwc.TemplateComponent_Out();
            public AXOpen.Io.AxoHardwareDiagnostics HardwareDiagnosticsTask { get; set; } = new AXOpen.Io.AxoHardwareDiagnostics();
        }
    }
}