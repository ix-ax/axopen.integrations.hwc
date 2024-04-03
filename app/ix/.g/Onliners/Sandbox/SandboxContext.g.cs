using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;
using AXOpen.Integrations.Hwc;

public partial class SandboxContext : AXOpen.Core.AxoContext
{
    public OnlinerBool _manualControl { get; }

    public AXOpen.Integrations.Hwc.TemplateComponent _testCyclinder { get; }

    public OnlinerBool _homeSensor { get; }

    public OnlinerBool _workSensor { get; }

    public OnlinerBool _moveHomeSignal { get; }

    public OnlinerBool _moveWorkSignal { get; }

    partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
    partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
    public SandboxContext(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
    {
        Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
        PreConstruct(parent, readableTail, symbolTail);
        _manualControl = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_manualControl", "_manualControl");
        _testCyclinder = new AXOpen.Integrations.Hwc.TemplateComponent(this, "_testCyclinder", "_testCyclinder");
        _homeSensor = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_homeSensor", "_homeSensor");
        _workSensor = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_workSensor", "_workSensor");
        _moveHomeSignal = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_moveHomeSignal", "_moveHomeSignal");
        _moveWorkSignal = @Connector.ConnectorAdapter.AdapterFactory.CreateBOOL(this, "_moveWorkSignal", "_moveWorkSignal");
        PostConstruct(parent, readableTail, symbolTail);
    }

    public async override Task<T> OnlineToPlain<T>()
    {
        return await (dynamic)this.OnlineToPlainAsync();
    }

    public new async Task<Pocos.SandboxContext> OnlineToPlainAsync()
    {
        Pocos.SandboxContext plain = new Pocos.SandboxContext();
        await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
        plain._manualControl = _manualControl.LastValue;
#pragma warning disable CS0612
        plain._testCyclinder = await _testCyclinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        plain._homeSensor = _homeSensor.LastValue;
        plain._workSensor = _workSensor.LastValue;
        plain._moveHomeSignal = _moveHomeSignal.LastValue;
        plain._moveWorkSignal = _moveWorkSignal.LastValue;
        return plain;
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public new async Task<Pocos.SandboxContext> _OnlineToPlainNoacAsync()
    {
        Pocos.SandboxContext plain = new Pocos.SandboxContext();
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
        plain._manualControl = _manualControl.LastValue;
#pragma warning disable CS0612
        plain._testCyclinder = await _testCyclinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        plain._homeSensor = _homeSensor.LastValue;
        plain._workSensor = _workSensor.LastValue;
        plain._moveHomeSignal = _moveHomeSignal.LastValue;
        plain._moveWorkSignal = _moveWorkSignal.LastValue;
        return plain;
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    protected async Task<Pocos.SandboxContext> _OnlineToPlainNoacAsync(Pocos.SandboxContext plain)
    {
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
        plain._manualControl = _manualControl.LastValue;
#pragma warning disable CS0612
        plain._testCyclinder = await _testCyclinder._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        plain._homeSensor = _homeSensor.LastValue;
        plain._workSensor = _workSensor.LastValue;
        plain._moveHomeSignal = _moveHomeSignal.LastValue;
        plain._moveWorkSignal = _moveWorkSignal.LastValue;
        return plain;
    }

    public async override Task PlainToOnline<T>(T plain)
    {
        await this.PlainToOnlineAsync((dynamic)plain);
    }

    public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.SandboxContext plain)
    {
        await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
        _manualControl.LethargicWrite(plain._manualControl);
#pragma warning restore CS0612
#pragma warning disable CS0612
        await this._testCyclinder._PlainToOnlineNoacAsync(plain._testCyclinder);
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
        return await this.WriteAsync<IgnoreOnPocoOperation>();
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public async Task _PlainToOnlineNoacAsync(Pocos.SandboxContext plain)
    {
        await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
        _manualControl.LethargicWrite(plain._manualControl);
#pragma warning restore CS0612
#pragma warning disable CS0612
        await this._testCyclinder._PlainToOnlineNoacAsync(plain._testCyclinder);
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
    }

    public async override Task<T> ShadowToPlain<T>()
    {
        return await (dynamic)this.ShadowToPlainAsync();
    }

    public new async Task<Pocos.SandboxContext> ShadowToPlainAsync()
    {
        Pocos.SandboxContext plain = new Pocos.SandboxContext();
        await base.ShadowToPlainAsync(plain);
        plain._manualControl = _manualControl.Shadow;
        plain._testCyclinder = await _testCyclinder.ShadowToPlainAsync();
        plain._homeSensor = _homeSensor.Shadow;
        plain._workSensor = _workSensor.Shadow;
        plain._moveHomeSignal = _moveHomeSignal.Shadow;
        plain._moveWorkSignal = _moveWorkSignal.Shadow;
        return plain;
    }

    protected async Task<Pocos.SandboxContext> ShadowToPlainAsync(Pocos.SandboxContext plain)
    {
        await base.ShadowToPlainAsync(plain);
        plain._manualControl = _manualControl.Shadow;
        plain._testCyclinder = await _testCyclinder.ShadowToPlainAsync();
        plain._homeSensor = _homeSensor.Shadow;
        plain._workSensor = _workSensor.Shadow;
        plain._moveHomeSignal = _moveHomeSignal.Shadow;
        plain._moveWorkSignal = _moveWorkSignal.Shadow;
        return plain;
    }

    public async override Task PlainToShadow<T>(T plain)
    {
        await this.PlainToShadowAsync((dynamic)plain);
    }

    public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.SandboxContext plain)
    {
        await base.PlainToShadowAsync(plain);
        _manualControl.Shadow = plain._manualControl;
        await this._testCyclinder.PlainToShadowAsync(plain._testCyclinder);
        _homeSensor.Shadow = plain._homeSensor;
        _workSensor.Shadow = plain._workSensor;
        _moveHomeSignal.Shadow = plain._moveHomeSignal;
        _moveWorkSignal.Shadow = plain._moveWorkSignal;
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
    public new async Task<bool> DetectsAnyChangeAsync(Pocos.SandboxContext plain, Pocos.SandboxContext latest = null)
    {
        if (latest == null)
            latest = await this._OnlineToPlainNoacAsync();
        var somethingChanged = false;
        return await Task.Run(async () =>
        {
            if (await base.DetectsAnyChangeAsync(plain))
                return true;
            if (plain._manualControl != _manualControl.LastValue)
                somethingChanged = true;
            if (await _testCyclinder.DetectsAnyChangeAsync(plain._testCyclinder, latest._testCyclinder))
                somethingChanged = true;
            if (plain._homeSensor != _homeSensor.LastValue)
                somethingChanged = true;
            if (plain._workSensor != _workSensor.LastValue)
                somethingChanged = true;
            if (plain._moveHomeSignal != _moveHomeSignal.LastValue)
                somethingChanged = true;
            if (plain._moveWorkSignal != _moveWorkSignal.LastValue)
                somethingChanged = true;
            plain = latest;
            return somethingChanged;
        });
    }

    public new void Poll()
    {
        this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
    }

    public new Pocos.SandboxContext CreateEmptyPoco()
    {
        return new Pocos.SandboxContext();
    }
}