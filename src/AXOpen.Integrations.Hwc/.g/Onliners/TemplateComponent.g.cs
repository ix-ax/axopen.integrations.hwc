using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using AXOpen.Core;
using AXOpen.Messaging;
using AXOpen.Messaging.Static;

namespace AXOpen.Integrations.Hwc
{
    public partial class TemplateComponent : AXOpen.Core.AxoComponent
    {
        [Container(Layout.Wrap)]
        [ComponentHeader()]
        public AXOpen.Core.AxoTask MoveToWorkTask { get; }

        [Container(Layout.Wrap)]
        [ComponentHeader()]
        public AXOpen.Core.AxoTask MoveToHomeTask { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Tasks")]
        public AXOpen.Core.AxoTask RestoreTask { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Tasks")]
        public AXOpen.Core.AxoTask StopTask { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_10steps_1 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_10steps_2 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_10steps_3 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_10steps_4 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_10steps_5 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_20steps_1 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_20steps_2 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_20steps_3 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_20steps_4 { get; }

        [Container(Layout.Wrap)]
        [ComponentDetails("Template tasks")]
        public AXOpen.Core.AxoTask TemplateTask_20steps_5 { get; }

        [Container(Layout.Stack)]
        [ComponentDetails("Config")]
        [ReadOnly()]
        public AXOpen.Integrations.Hwc.TemplateComponent_Config Config { get; }

        [Container(Layout.Stack)]
        [ComponentDetails("Status")]
        [ReadOnly()]
        public AXOpen.Integrations.Hwc.TemplateComponent_Component_Status Status { get; }

        public AXOpen.Messaging.Static.AxoMessenger Messenger { get; }

        public AXOpen.Messaging.Static.AxoMessenger TaskMessenger { get; }

        [ComponentDetails("HARDWARE SIGNALS")]
        [Container(Layout.Wrap)]
        [Group(GroupLayout.GroupBox)]
        [ReadOnly()]
        public AXOpen.Integrations.Hwc.TemplateComponent_In Inputs { get; }

        [ComponentDetails("HARDWARE SIGNALS")]
        [Container(Layout.Wrap)]
        [Group(GroupLayout.GroupBox)]
        [ReadOnly()]
        public AXOpen.Integrations.Hwc.TemplateComponent_Out Outputs { get; }

        [Container(Layout.Stack)]
        [ComponentDetails("Hardware diagnostics")]
        public AXOpen.Io.AxoHardwareDiagnostics HardwareDiagnosticsTask { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public TemplateComponent(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            PreConstruct(parent, readableTail, symbolTail);
            MoveToWorkTask = new AXOpen.Core.AxoTask(this, "<#Move to work#>", "MoveToWorkTask");
            MoveToWorkTask.AttributeName = "<#Move to work#>";
            MoveToHomeTask = new AXOpen.Core.AxoTask(this, "<#Move to home#>", "MoveToHomeTask");
            MoveToHomeTask.AttributeName = "<#Move to home#>";
            RestoreTask = new AXOpen.Core.AxoTask(this, "<#Restore#>", "RestoreTask");
            RestoreTask.AttributeName = "<#Restore#>";
            StopTask = new AXOpen.Core.AxoTask(this, "<#Stop#>", "StopTask");
            StopTask.AttributeName = "<#Stop#>";
            TemplateTask_10steps_1 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_10steps_1#>", "TemplateTask_10steps_1");
            TemplateTask_10steps_1.AttributeName = "<#TemplateTask_10steps_1#>";
            TemplateTask_10steps_2 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_10steps_2#>", "TemplateTask_10steps_2");
            TemplateTask_10steps_2.AttributeName = "<#TemplateTask_10steps_2#>";
            TemplateTask_10steps_3 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_10steps_3#>", "TemplateTask_10steps_3");
            TemplateTask_10steps_3.AttributeName = "<#TemplateTask_10steps_3#>";
            TemplateTask_10steps_4 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_10steps_4#>", "TemplateTask_10steps_4");
            TemplateTask_10steps_4.AttributeName = "<#TemplateTask_10steps_4#>";
            TemplateTask_10steps_5 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_10steps_5#>", "TemplateTask_10steps_5");
            TemplateTask_10steps_5.AttributeName = "<#TemplateTask_10steps_5#>";
            TemplateTask_20steps_1 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_20steps_1#>", "TemplateTask_20steps_1");
            TemplateTask_20steps_1.AttributeName = "<#TemplateTask_20steps_1#>";
            TemplateTask_20steps_2 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_20steps_2#>", "TemplateTask_20steps_2");
            TemplateTask_20steps_2.AttributeName = "<#TemplateTask_20steps_2#>";
            TemplateTask_20steps_3 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_20steps_3#>", "TemplateTask_20steps_3");
            TemplateTask_20steps_3.AttributeName = "<#TemplateTask_20steps_3#>";
            TemplateTask_20steps_4 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_20steps_4#>", "TemplateTask_20steps_4");
            TemplateTask_20steps_4.AttributeName = "<#TemplateTask_20steps_4#>";
            TemplateTask_20steps_5 = new AXOpen.Core.AxoTask(this, "<#TemplateTask_20steps_5#>", "TemplateTask_20steps_5");
            TemplateTask_20steps_5.AttributeName = "<#TemplateTask_20steps_5#>";
            Config = new AXOpen.Integrations.Hwc.TemplateComponent_Config(this, "Config", "Config");
            Config.MakeReadOnly();
            Status = new AXOpen.Integrations.Hwc.TemplateComponent_Component_Status(this, "Status", "Status");
            Status.MakeReadOnly();
            Messenger = new AXOpen.Messaging.Static.AxoMessenger(this, "Messenger", "Messenger");
            TaskMessenger = new AXOpen.Messaging.Static.AxoMessenger(this, "TaskMessenger", "TaskMessenger");
            Inputs = new AXOpen.Integrations.Hwc.TemplateComponent_In(this, "<#Inputs#>", "Inputs");
            Inputs.AttributeName = "<#Inputs#>";
            Inputs.MakeReadOnly();
            Outputs = new AXOpen.Integrations.Hwc.TemplateComponent_Out(this, "<#Outputs#>", "Outputs");
            Outputs.AttributeName = "<#Outputs#>";
            Outputs.MakeReadOnly();
            HardwareDiagnosticsTask = new AXOpen.Io.AxoHardwareDiagnostics(this, "<#Update diagnostics#>", "HardwareDiagnosticsTask");
            HardwareDiagnosticsTask.AttributeName = "<#Update diagnostics#>";
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async override Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public new async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent> OnlineToPlainAsync()
        {
            Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain = new Pocos.AXOpen.Integrations.Hwc.TemplateComponent();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToWorkTask = await MoveToWorkTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToHomeTask = await MoveToHomeTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.RestoreTask = await RestoreTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StopTask = await StopTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_1 = await TemplateTask_10steps_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_2 = await TemplateTask_10steps_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_3 = await TemplateTask_10steps_3._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_4 = await TemplateTask_10steps_4._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_5 = await TemplateTask_10steps_5._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_1 = await TemplateTask_20steps_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_2 = await TemplateTask_20steps_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_3 = await TemplateTask_20steps_3._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_4 = await TemplateTask_20steps_4._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_5 = await TemplateTask_20steps_5._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Config = await Config._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Status = await Status._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Messenger = await Messenger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TaskMessenger = await TaskMessenger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Inputs = await Inputs._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Outputs = await Outputs._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.HardwareDiagnosticsTask = await HardwareDiagnosticsTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent> _OnlineToPlainNoacAsync()
        {
            Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain = new Pocos.AXOpen.Integrations.Hwc.TemplateComponent();
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToWorkTask = await MoveToWorkTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToHomeTask = await MoveToHomeTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.RestoreTask = await RestoreTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StopTask = await StopTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_1 = await TemplateTask_10steps_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_2 = await TemplateTask_10steps_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_3 = await TemplateTask_10steps_3._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_4 = await TemplateTask_10steps_4._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_5 = await TemplateTask_10steps_5._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_1 = await TemplateTask_20steps_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_2 = await TemplateTask_20steps_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_3 = await TemplateTask_20steps_3._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_4 = await TemplateTask_20steps_4._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_5 = await TemplateTask_20steps_5._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Config = await Config._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Status = await Status._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Messenger = await Messenger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TaskMessenger = await TaskMessenger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Inputs = await Inputs._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Outputs = await Outputs._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.HardwareDiagnosticsTask = await HardwareDiagnosticsTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent> _OnlineToPlainNoacAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain)
        {
#pragma warning disable CS0612
            await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToWorkTask = await MoveToWorkTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.MoveToHomeTask = await MoveToHomeTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.RestoreTask = await RestoreTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.StopTask = await StopTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_1 = await TemplateTask_10steps_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_2 = await TemplateTask_10steps_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_3 = await TemplateTask_10steps_3._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_4 = await TemplateTask_10steps_4._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_10steps_5 = await TemplateTask_10steps_5._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_1 = await TemplateTask_20steps_1._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_2 = await TemplateTask_20steps_2._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_3 = await TemplateTask_20steps_3._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_4 = await TemplateTask_20steps_4._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TemplateTask_20steps_5 = await TemplateTask_20steps_5._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Config = await Config._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Status = await Status._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Messenger = await Messenger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.TaskMessenger = await TaskMessenger._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Inputs = await Inputs._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.Outputs = await Outputs._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
            plain.HardwareDiagnosticsTask = await HardwareDiagnosticsTask._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async override Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.MoveToWorkTask._PlainToOnlineNoacAsync(plain.MoveToWorkTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.MoveToHomeTask._PlainToOnlineNoacAsync(plain.MoveToHomeTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.RestoreTask._PlainToOnlineNoacAsync(plain.RestoreTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StopTask._PlainToOnlineNoacAsync(plain.StopTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_1._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_2._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_3._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_3);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_4._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_4);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_5._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_5);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_1._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_2._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_3._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_3);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_4._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_4);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_5._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_5);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Config._PlainToOnlineNoacAsync(plain.Config);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Status._PlainToOnlineNoacAsync(plain.Status);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Messenger._PlainToOnlineNoacAsync(plain.Messenger);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TaskMessenger._PlainToOnlineNoacAsync(plain.TaskMessenger);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Inputs._PlainToOnlineNoacAsync(plain.Inputs);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Outputs._PlainToOnlineNoacAsync(plain.Outputs);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.HardwareDiagnosticsTask._PlainToOnlineNoacAsync(plain.HardwareDiagnosticsTask);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain)
        {
            await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
            await this.MoveToWorkTask._PlainToOnlineNoacAsync(plain.MoveToWorkTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.MoveToHomeTask._PlainToOnlineNoacAsync(plain.MoveToHomeTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.RestoreTask._PlainToOnlineNoacAsync(plain.RestoreTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.StopTask._PlainToOnlineNoacAsync(plain.StopTask);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_1._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_2._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_3._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_3);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_4._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_4);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_10steps_5._PlainToOnlineNoacAsync(plain.TemplateTask_10steps_5);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_1._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_1);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_2._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_2);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_3._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_3);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_4._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_4);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TemplateTask_20steps_5._PlainToOnlineNoacAsync(plain.TemplateTask_20steps_5);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Config._PlainToOnlineNoacAsync(plain.Config);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Status._PlainToOnlineNoacAsync(plain.Status);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Messenger._PlainToOnlineNoacAsync(plain.Messenger);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.TaskMessenger._PlainToOnlineNoacAsync(plain.TaskMessenger);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Inputs._PlainToOnlineNoacAsync(plain.Inputs);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.Outputs._PlainToOnlineNoacAsync(plain.Outputs);
#pragma warning restore CS0612
#pragma warning disable CS0612
            await this.HardwareDiagnosticsTask._PlainToOnlineNoacAsync(plain.HardwareDiagnosticsTask);
#pragma warning restore CS0612
        }

        public async override Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public new async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent> ShadowToPlainAsync()
        {
            Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain = new Pocos.AXOpen.Integrations.Hwc.TemplateComponent();
            await base.ShadowToPlainAsync(plain);
            plain.MoveToWorkTask = await MoveToWorkTask.ShadowToPlainAsync();
            plain.MoveToHomeTask = await MoveToHomeTask.ShadowToPlainAsync();
            plain.RestoreTask = await RestoreTask.ShadowToPlainAsync();
            plain.StopTask = await StopTask.ShadowToPlainAsync();
            plain.TemplateTask_10steps_1 = await TemplateTask_10steps_1.ShadowToPlainAsync();
            plain.TemplateTask_10steps_2 = await TemplateTask_10steps_2.ShadowToPlainAsync();
            plain.TemplateTask_10steps_3 = await TemplateTask_10steps_3.ShadowToPlainAsync();
            plain.TemplateTask_10steps_4 = await TemplateTask_10steps_4.ShadowToPlainAsync();
            plain.TemplateTask_10steps_5 = await TemplateTask_10steps_5.ShadowToPlainAsync();
            plain.TemplateTask_20steps_1 = await TemplateTask_20steps_1.ShadowToPlainAsync();
            plain.TemplateTask_20steps_2 = await TemplateTask_20steps_2.ShadowToPlainAsync();
            plain.TemplateTask_20steps_3 = await TemplateTask_20steps_3.ShadowToPlainAsync();
            plain.TemplateTask_20steps_4 = await TemplateTask_20steps_4.ShadowToPlainAsync();
            plain.TemplateTask_20steps_5 = await TemplateTask_20steps_5.ShadowToPlainAsync();
            plain.Config = await Config.ShadowToPlainAsync();
            plain.Status = await Status.ShadowToPlainAsync();
            plain.Messenger = await Messenger.ShadowToPlainAsync();
            plain.TaskMessenger = await TaskMessenger.ShadowToPlainAsync();
            plain.Inputs = await Inputs.ShadowToPlainAsync();
            plain.Outputs = await Outputs.ShadowToPlainAsync();
            plain.HardwareDiagnosticsTask = await HardwareDiagnosticsTask.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent> ShadowToPlainAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain)
        {
            await base.ShadowToPlainAsync(plain);
            plain.MoveToWorkTask = await MoveToWorkTask.ShadowToPlainAsync();
            plain.MoveToHomeTask = await MoveToHomeTask.ShadowToPlainAsync();
            plain.RestoreTask = await RestoreTask.ShadowToPlainAsync();
            plain.StopTask = await StopTask.ShadowToPlainAsync();
            plain.TemplateTask_10steps_1 = await TemplateTask_10steps_1.ShadowToPlainAsync();
            plain.TemplateTask_10steps_2 = await TemplateTask_10steps_2.ShadowToPlainAsync();
            plain.TemplateTask_10steps_3 = await TemplateTask_10steps_3.ShadowToPlainAsync();
            plain.TemplateTask_10steps_4 = await TemplateTask_10steps_4.ShadowToPlainAsync();
            plain.TemplateTask_10steps_5 = await TemplateTask_10steps_5.ShadowToPlainAsync();
            plain.TemplateTask_20steps_1 = await TemplateTask_20steps_1.ShadowToPlainAsync();
            plain.TemplateTask_20steps_2 = await TemplateTask_20steps_2.ShadowToPlainAsync();
            plain.TemplateTask_20steps_3 = await TemplateTask_20steps_3.ShadowToPlainAsync();
            plain.TemplateTask_20steps_4 = await TemplateTask_20steps_4.ShadowToPlainAsync();
            plain.TemplateTask_20steps_5 = await TemplateTask_20steps_5.ShadowToPlainAsync();
            plain.Config = await Config.ShadowToPlainAsync();
            plain.Status = await Status.ShadowToPlainAsync();
            plain.Messenger = await Messenger.ShadowToPlainAsync();
            plain.TaskMessenger = await TaskMessenger.ShadowToPlainAsync();
            plain.Inputs = await Inputs.ShadowToPlainAsync();
            plain.Outputs = await Outputs.ShadowToPlainAsync();
            plain.HardwareDiagnosticsTask = await HardwareDiagnosticsTask.ShadowToPlainAsync();
            return plain;
        }

        public async override Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain)
        {
            await base.PlainToShadowAsync(plain);
            await this.MoveToWorkTask.PlainToShadowAsync(plain.MoveToWorkTask);
            await this.MoveToHomeTask.PlainToShadowAsync(plain.MoveToHomeTask);
            await this.RestoreTask.PlainToShadowAsync(plain.RestoreTask);
            await this.StopTask.PlainToShadowAsync(plain.StopTask);
            await this.TemplateTask_10steps_1.PlainToShadowAsync(plain.TemplateTask_10steps_1);
            await this.TemplateTask_10steps_2.PlainToShadowAsync(plain.TemplateTask_10steps_2);
            await this.TemplateTask_10steps_3.PlainToShadowAsync(plain.TemplateTask_10steps_3);
            await this.TemplateTask_10steps_4.PlainToShadowAsync(plain.TemplateTask_10steps_4);
            await this.TemplateTask_10steps_5.PlainToShadowAsync(plain.TemplateTask_10steps_5);
            await this.TemplateTask_20steps_1.PlainToShadowAsync(plain.TemplateTask_20steps_1);
            await this.TemplateTask_20steps_2.PlainToShadowAsync(plain.TemplateTask_20steps_2);
            await this.TemplateTask_20steps_3.PlainToShadowAsync(plain.TemplateTask_20steps_3);
            await this.TemplateTask_20steps_4.PlainToShadowAsync(plain.TemplateTask_20steps_4);
            await this.TemplateTask_20steps_5.PlainToShadowAsync(plain.TemplateTask_20steps_5);
            await this.Config.PlainToShadowAsync(plain.Config);
            await this.Status.PlainToShadowAsync(plain.Status);
            await this.Messenger.PlainToShadowAsync(plain.Messenger);
            await this.TaskMessenger.PlainToShadowAsync(plain.TaskMessenger);
            await this.Inputs.PlainToShadowAsync(plain.Inputs);
            await this.Outputs.PlainToShadowAsync(plain.Outputs);
            await this.HardwareDiagnosticsTask.PlainToShadowAsync(plain.HardwareDiagnosticsTask);
            return this.RetrievePrimitives();
        }

        ///<inheritdoc/>
        public async override Task<bool> AnyChangeAsync<T>(T plain)
        {
            return await this.DetectsAnyChangeAsync((dynamic)plain);
        }

        ///<summary>
        ///Compares if the current plain object has changed from the previous object.This method is used by the framework to determine if the object has changed and needs to be updated.
        ///[!NOTE] Any member in the hierarchy that is ignored by the compilers (e.g. when CompilerOmitAttribute is used) will not be compared, and therefore will not be detected as changed.
        ///</summary>
        public new async Task<bool> DetectsAnyChangeAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent plain, Pocos.AXOpen.Integrations.Hwc.TemplateComponent latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await base.DetectsAnyChangeAsync(plain))
                    return true;
                if (await MoveToWorkTask.DetectsAnyChangeAsync(plain.MoveToWorkTask, latest.MoveToWorkTask))
                    somethingChanged = true;
                if (await MoveToHomeTask.DetectsAnyChangeAsync(plain.MoveToHomeTask, latest.MoveToHomeTask))
                    somethingChanged = true;
                if (await RestoreTask.DetectsAnyChangeAsync(plain.RestoreTask, latest.RestoreTask))
                    somethingChanged = true;
                if (await StopTask.DetectsAnyChangeAsync(plain.StopTask, latest.StopTask))
                    somethingChanged = true;
                if (await TemplateTask_10steps_1.DetectsAnyChangeAsync(plain.TemplateTask_10steps_1, latest.TemplateTask_10steps_1))
                    somethingChanged = true;
                if (await TemplateTask_10steps_2.DetectsAnyChangeAsync(plain.TemplateTask_10steps_2, latest.TemplateTask_10steps_2))
                    somethingChanged = true;
                if (await TemplateTask_10steps_3.DetectsAnyChangeAsync(plain.TemplateTask_10steps_3, latest.TemplateTask_10steps_3))
                    somethingChanged = true;
                if (await TemplateTask_10steps_4.DetectsAnyChangeAsync(plain.TemplateTask_10steps_4, latest.TemplateTask_10steps_4))
                    somethingChanged = true;
                if (await TemplateTask_10steps_5.DetectsAnyChangeAsync(plain.TemplateTask_10steps_5, latest.TemplateTask_10steps_5))
                    somethingChanged = true;
                if (await TemplateTask_20steps_1.DetectsAnyChangeAsync(plain.TemplateTask_20steps_1, latest.TemplateTask_20steps_1))
                    somethingChanged = true;
                if (await TemplateTask_20steps_2.DetectsAnyChangeAsync(plain.TemplateTask_20steps_2, latest.TemplateTask_20steps_2))
                    somethingChanged = true;
                if (await TemplateTask_20steps_3.DetectsAnyChangeAsync(plain.TemplateTask_20steps_3, latest.TemplateTask_20steps_3))
                    somethingChanged = true;
                if (await TemplateTask_20steps_4.DetectsAnyChangeAsync(plain.TemplateTask_20steps_4, latest.TemplateTask_20steps_4))
                    somethingChanged = true;
                if (await TemplateTask_20steps_5.DetectsAnyChangeAsync(plain.TemplateTask_20steps_5, latest.TemplateTask_20steps_5))
                    somethingChanged = true;
                if (await Config.DetectsAnyChangeAsync(plain.Config, latest.Config))
                    somethingChanged = true;
                if (await Status.DetectsAnyChangeAsync(plain.Status, latest.Status))
                    somethingChanged = true;
                if (await Messenger.DetectsAnyChangeAsync(plain.Messenger, latest.Messenger))
                    somethingChanged = true;
                if (await TaskMessenger.DetectsAnyChangeAsync(plain.TaskMessenger, latest.TaskMessenger))
                    somethingChanged = true;
                if (await Inputs.DetectsAnyChangeAsync(plain.Inputs, latest.Inputs))
                    somethingChanged = true;
                if (await Outputs.DetectsAnyChangeAsync(plain.Outputs, latest.Outputs))
                    somethingChanged = true;
                if (await HardwareDiagnosticsTask.DetectsAnyChangeAsync(plain.HardwareDiagnosticsTask, latest.HardwareDiagnosticsTask))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public new void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public new Pocos.AXOpen.Integrations.Hwc.TemplateComponent CreateEmptyPoco()
        {
            return new Pocos.AXOpen.Integrations.Hwc.TemplateComponent();
        }
    }
}