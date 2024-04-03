using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using AXOpen.Core;
using AXOpen.Integrations.Hwc;

public partial class Component_1 : AXOpen.Core.AxoObject
{
    public AXOpen.Integrations.Hwc.TemplateComponent ExampleCylinder { get; }

    public OnlinerBool ActivateManualControl { get; }

    public OnlinerBool _homeSensor { get; }

    public OnlinerBool _workSensor { get; }

    public OnlinerBool _moveHomeSignal { get; }

    public OnlinerBool _moveWorkSignal { get; }

    public AXOpen.Core.AxoSequencer Sequencer { get; }

    public AXOpen.Core.AxoStep[] Steps { get; }

    partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
    partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
    public Component_1(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
    {
        Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
        PreConstruct(parent, readableTail, symbolTail);
        ExampleCylinder = new AXOpen.Integrations.Hwc.TemplateComponent(this, "ExampleCylinder", "ExampleCylinder");
        ActivateManualControl = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "<#Activate manual control#>", "ActivateManualControl");
        ActivateManualControl.AttributeName = "<#Activate manual control#>";
        _homeSensor = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_homeSensor", "_homeSensor");
        _workSensor = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_workSensor", "_workSensor");
        _moveHomeSignal = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_moveHomeSignal", "_moveHomeSignal");
        _moveWorkSignal = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_moveWorkSignal", "_moveWorkSignal");
        Sequencer = new AXOpen.Core.AxoSequencer(this, "Sequencer", "Sequencer");
        Steps = new AXOpen.Core.AxoStep[4];
        AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(Steps, this, "Steps", "Steps", (p, rt, st) => new AXOpen.Core.AxoStep(p, rt, st), new[] { (0, 3) });
        PostConstruct(parent, readableTail, symbolTail);
    }

    public async override Task<T> OnlineToPlain<T>()
    {
        return await (dynamic)this.OnlineToPlainAsync();
    }

    public new async Task<Pocos.Component_1> OnlineToPlainAsync()
    {
        Pocos.Component_1 plain = new Pocos.Component_1();
        await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.ExampleCylinder = await ExampleCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        plain.ActivateManualControl = ActivateManualControl.LastValue;
        plain._homeSensor = _homeSensor.LastValue;
        plain._workSensor = _workSensor.LastValue;
        plain._moveHomeSignal = _moveHomeSignal.LastValue;
        plain._moveWorkSignal = _moveWorkSignal.LastValue;
#pragma warning disable CS0612
        plain.Sequencer = await Sequencer._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.Steps = Steps.Select(async p => await p._OnlineToPlainNoacAsync()).Select(p => p.Result).ToArray();
#pragma warning restore CS0612
        return plain;
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public new async Task<Pocos.Component_1> _OnlineToPlainNoacAsync()
    {
        Pocos.Component_1 plain = new Pocos.Component_1();
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.ExampleCylinder = await ExampleCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        plain.ActivateManualControl = ActivateManualControl.LastValue;
        plain._homeSensor = _homeSensor.LastValue;
        plain._workSensor = _workSensor.LastValue;
        plain._moveHomeSignal = _moveHomeSignal.LastValue;
        plain._moveWorkSignal = _moveWorkSignal.LastValue;
#pragma warning disable CS0612
        plain.Sequencer = await Sequencer._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.Steps = Steps.Select(async p => await p._OnlineToPlainNoacAsync()).Select(p => p.Result).ToArray();
#pragma warning restore CS0612
        return plain;
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    protected async Task<Pocos.Component_1> _OnlineToPlainNoacAsync(Pocos.Component_1 plain)
    {
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.ExampleCylinder = await ExampleCylinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        plain.ActivateManualControl = ActivateManualControl.LastValue;
        plain._homeSensor = _homeSensor.LastValue;
        plain._workSensor = _workSensor.LastValue;
        plain._moveHomeSignal = _moveHomeSignal.LastValue;
        plain._moveWorkSignal = _moveWorkSignal.LastValue;
#pragma warning disable CS0612
        plain.Sequencer = await Sequencer._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.Steps = Steps.Select(async p => await p._OnlineToPlainNoacAsync()).Select(p => p.Result).ToArray();
#pragma warning restore CS0612
        return plain;
    }

    public async override Task PlainToOnline<T>(T plain)
    {
        await this.PlainToOnlineAsync((dynamic)plain);
    }

    public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.Component_1 plain)
    {
        await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
        await this.ExampleCylinder._PlainToOnlineNoacAsync(plain.ExampleCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
        ActivateManualControl.LethargicWrite(plain.ActivateManualControl);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _homeSensor.LethargicWrite(plain._homeSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _workSensor.LethargicWrite(plain._workSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _moveHomeSignal.LethargicWrite(plain._moveHomeSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _moveWorkSignal.LethargicWrite(plain._moveWorkSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
        await this.Sequencer._PlainToOnlineNoacAsync(plain.Sequencer);
#pragma warning restore CS0612
        var _Steps_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
        Steps.Select(p => p._PlainToOnlineNoacAsync(plain.Steps[_Steps_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
        return await this.WriteAsync<IgnoreOnPocoOperation>();
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public async Task _PlainToOnlineNoacAsync(Pocos.Component_1 plain)
    {
        await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
        await this.ExampleCylinder._PlainToOnlineNoacAsync(plain.ExampleCylinder);
#pragma warning restore CS0612
#pragma warning disable CS0612
        ActivateManualControl.LethargicWrite(plain.ActivateManualControl);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _homeSensor.LethargicWrite(plain._homeSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _workSensor.LethargicWrite(plain._workSensor);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _moveHomeSignal.LethargicWrite(plain._moveHomeSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
        _moveWorkSignal.LethargicWrite(plain._moveWorkSignal);
#pragma warning restore CS0612
#pragma warning disable CS0612
        await this.Sequencer._PlainToOnlineNoacAsync(plain.Sequencer);
#pragma warning restore CS0612
        var _Steps_i_FE8484DAB3 = 0;
#pragma warning disable CS0612
        Steps.Select(p => p._PlainToOnlineNoacAsync(plain.Steps[_Steps_i_FE8484DAB3++])).ToArray();
#pragma warning restore CS0612
    }

    public async override Task<T> ShadowToPlain<T>()
    {
        return await (dynamic)this.ShadowToPlainAsync();
    }

    public new async Task<Pocos.Component_1> ShadowToPlainAsync()
    {
        Pocos.Component_1 plain = new Pocos.Component_1();
        await base.ShadowToPlainAsync(plain);
        plain.ExampleCylinder = await ExampleCylinder.ShadowToPlainAsync();
        plain.ActivateManualControl = ActivateManualControl.Shadow;
        plain._homeSensor = _homeSensor.Shadow;
        plain._workSensor = _workSensor.Shadow;
        plain._moveHomeSignal = _moveHomeSignal.Shadow;
        plain._moveWorkSignal = _moveWorkSignal.Shadow;
        plain.Sequencer = await Sequencer.ShadowToPlainAsync();
        plain.Steps = Steps.Select(async p => await p.ShadowToPlainAsync()).Select(p => p.Result).ToArray();
        return plain;
    }

    protected async Task<Pocos.Component_1> ShadowToPlainAsync(Pocos.Component_1 plain)
    {
        await base.ShadowToPlainAsync(plain);
        plain.ExampleCylinder = await ExampleCylinder.ShadowToPlainAsync();
        plain.ActivateManualControl = ActivateManualControl.Shadow;
        plain._homeSensor = _homeSensor.Shadow;
        plain._workSensor = _workSensor.Shadow;
        plain._moveHomeSignal = _moveHomeSignal.Shadow;
        plain._moveWorkSignal = _moveWorkSignal.Shadow;
        plain.Sequencer = await Sequencer.ShadowToPlainAsync();
        plain.Steps = Steps.Select(async p => await p.ShadowToPlainAsync()).Select(p => p.Result).ToArray();
        return plain;
    }

    public async override Task PlainToShadow<T>(T plain)
    {
        await this.PlainToShadowAsync((dynamic)plain);
    }

    public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.Component_1 plain)
    {
        await base.PlainToShadowAsync(plain);
        await this.ExampleCylinder.PlainToShadowAsync(plain.ExampleCylinder);
        ActivateManualControl.Shadow = plain.ActivateManualControl;
        _homeSensor.Shadow = plain._homeSensor;
        _workSensor.Shadow = plain._workSensor;
        _moveHomeSignal.Shadow = plain._moveHomeSignal;
        _moveWorkSignal.Shadow = plain._moveWorkSignal;
        await this.Sequencer.PlainToShadowAsync(plain.Sequencer);
        var _Steps_i_FE8484DAB3 = 0;
        Steps.Select(p => p.PlainToShadowAsync(plain.Steps[_Steps_i_FE8484DAB3++])).ToArray();
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
    public new async Task<bool> DetectsAnyChangeAsync(Pocos.Component_1 plain, Pocos.Component_1 latest = null)
    {
        if (latest == null)
            latest = await this._OnlineToPlainNoacAsync();
        var somethingChanged = false;
        return await Task.Run(async () =>
        {
            if (await base.DetectsAnyChangeAsync(plain))
                return true;
            if (await ExampleCylinder.DetectsAnyChangeAsync(plain.ExampleCylinder, latest.ExampleCylinder))
                somethingChanged = true;
            if (plain.ActivateManualControl != ActivateManualControl.LastValue)
                somethingChanged = true;
            if (plain._homeSensor != _homeSensor.LastValue)
                somethingChanged = true;
            if (plain._workSensor != _workSensor.LastValue)
                somethingChanged = true;
            if (plain._moveHomeSignal != _moveHomeSignal.LastValue)
                somethingChanged = true;
            if (plain._moveWorkSignal != _moveWorkSignal.LastValue)
                somethingChanged = true;
            if (await Sequencer.DetectsAnyChangeAsync(plain.Sequencer, latest.Sequencer))
                somethingChanged = true;
            for (int i760901_3001_mimi = 0; i760901_3001_mimi < latest.Steps.Length; i760901_3001_mimi++)
            {
                if (await Steps.ElementAt(i760901_3001_mimi).DetectsAnyChangeAsync(plain.Steps[i760901_3001_mimi], latest.Steps[i760901_3001_mimi]))
                    somethingChanged = true;
            }

            plain = latest;
            return somethingChanged;
        });
    }

    public new void Poll()
    {
        this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
    }

    public new Pocos.Component_1 CreateEmptyPoco()
    {
        return new Pocos.Component_1();
    }
}