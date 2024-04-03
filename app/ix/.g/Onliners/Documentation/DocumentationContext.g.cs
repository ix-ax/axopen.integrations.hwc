using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

public partial class DocumentationContext : AXOpen.Core.AxoContext
{
    public Component_1 componentOne { get; }

    public Component_2 componentTwo { get; }

    partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
    partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
    public DocumentationContext(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail) : base(parent, readableTail, symbolTail)
    {
        Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
        PreConstruct(parent, readableTail, symbolTail);
        componentOne = new Component_1(this, "componentOne", "componentOne");
        componentTwo = new Component_2(this, "componentTwo", "componentTwo");
        PostConstruct(parent, readableTail, symbolTail);
    }

    public async override Task<T> OnlineToPlain<T>()
    {
        return await (dynamic)this.OnlineToPlainAsync();
    }

    public new async Task<Pocos.DocumentationContext> OnlineToPlainAsync()
    {
        Pocos.DocumentationContext plain = new Pocos.DocumentationContext();
        await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.componentOne = await componentOne._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.componentTwo = await componentTwo._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        return plain;
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public new async Task<Pocos.DocumentationContext> _OnlineToPlainNoacAsync()
    {
        Pocos.DocumentationContext plain = new Pocos.DocumentationContext();
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.componentOne = await componentOne._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.componentTwo = await componentTwo._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        return plain;
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    protected async Task<Pocos.DocumentationContext> _OnlineToPlainNoacAsync(Pocos.DocumentationContext plain)
    {
#pragma warning disable CS0612
        await base._OnlineToPlainNoacAsync(plain);
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.componentOne = await componentOne._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
#pragma warning disable CS0612
        plain.componentTwo = await componentTwo._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
        return plain;
    }

    public async override Task PlainToOnline<T>(T plain)
    {
        await this.PlainToOnlineAsync((dynamic)plain);
    }

    public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.DocumentationContext plain)
    {
        await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
        await this.componentOne._PlainToOnlineNoacAsync(plain.componentOne);
#pragma warning restore CS0612
#pragma warning disable CS0612
        await this.componentTwo._PlainToOnlineNoacAsync(plain.componentTwo);
#pragma warning restore CS0612
        return await this.WriteAsync<IgnoreOnPocoOperation>();
    }

    [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public async Task _PlainToOnlineNoacAsync(Pocos.DocumentationContext plain)
    {
        await base._PlainToOnlineNoacAsync(plain);
#pragma warning disable CS0612
        await this.componentOne._PlainToOnlineNoacAsync(plain.componentOne);
#pragma warning restore CS0612
#pragma warning disable CS0612
        await this.componentTwo._PlainToOnlineNoacAsync(plain.componentTwo);
#pragma warning restore CS0612
    }

    public async override Task<T> ShadowToPlain<T>()
    {
        return await (dynamic)this.ShadowToPlainAsync();
    }

    public new async Task<Pocos.DocumentationContext> ShadowToPlainAsync()
    {
        Pocos.DocumentationContext plain = new Pocos.DocumentationContext();
        await base.ShadowToPlainAsync(plain);
        plain.componentOne = await componentOne.ShadowToPlainAsync();
        plain.componentTwo = await componentTwo.ShadowToPlainAsync();
        return plain;
    }

    protected async Task<Pocos.DocumentationContext> ShadowToPlainAsync(Pocos.DocumentationContext plain)
    {
        await base.ShadowToPlainAsync(plain);
        plain.componentOne = await componentOne.ShadowToPlainAsync();
        plain.componentTwo = await componentTwo.ShadowToPlainAsync();
        return plain;
    }

    public async override Task PlainToShadow<T>(T plain)
    {
        await this.PlainToShadowAsync((dynamic)plain);
    }

    public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.DocumentationContext plain)
    {
        await base.PlainToShadowAsync(plain);
        await this.componentOne.PlainToShadowAsync(plain.componentOne);
        await this.componentTwo.PlainToShadowAsync(plain.componentTwo);
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
    public new async Task<bool> DetectsAnyChangeAsync(Pocos.DocumentationContext plain, Pocos.DocumentationContext latest = null)
    {
        if (latest == null)
            latest = await this._OnlineToPlainNoacAsync();
        var somethingChanged = false;
        return await Task.Run(async () =>
        {
            if (await base.DetectsAnyChangeAsync(plain))
                return true;
            if (await componentOne.DetectsAnyChangeAsync(plain.componentOne, latest.componentOne))
                somethingChanged = true;
            if (await componentTwo.DetectsAnyChangeAsync(plain.componentTwo, latest.componentTwo))
                somethingChanged = true;
            plain = latest;
            return somethingChanged;
        });
    }

    public new void Poll()
    {
        this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
    }

    public new Pocos.DocumentationContext CreateEmptyPoco()
    {
        return new Pocos.DocumentationContext();
    }
}