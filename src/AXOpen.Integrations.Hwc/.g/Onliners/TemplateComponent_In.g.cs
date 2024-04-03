using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

namespace AXOpen.Integrations.Hwc
{
    [Container(Layout.Wrap)]
    public partial class TemplateComponent_In : AXSharp.Connector.ITwinObject
    {
        [ReadOnly()]
        public AXOpen.Integrations.Hwc.TemplateComponent_Status Status { get; }

        partial void PreConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        partial void PostConstruct(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail);
        public TemplateComponent_In(AXSharp.Connector.ITwinObject parent, string readableTail, string symbolTail)
        {
            Symbol = AXSharp.Connector.Connector.CreateSymbol(parent.Symbol, symbolTail);
            this.@SymbolTail = symbolTail;
            this.@Connector = parent.GetConnector();
            this.@Parent = parent;
            HumanReadable = AXSharp.Connector.Connector.CreateHumanReadable(parent.HumanReadable, readableTail);
            PreConstruct(parent, readableTail, symbolTail);
            Status = new AXOpen.Integrations.Hwc.TemplateComponent_Status(this, "<#Status#>", "Status");
            Status.AttributeName = "<#Status#>";
            Status.MakeReadOnly();
            parent.AddChild(this);
            parent.AddKid(this);
            PostConstruct(parent, readableTail, symbolTail);
        }

        public async virtual Task<T> OnlineToPlain<T>()
        {
            return await (dynamic)this.OnlineToPlainAsync();
        }

        public async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In> OnlineToPlainAsync()
        {
            Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain = new Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In();
            await this.ReadAsync<IgnoreOnPocoOperation>();
#pragma warning disable CS0612
            plain.Status = await Status._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In> _OnlineToPlainNoacAsync()
        {
            Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain = new Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In();
#pragma warning disable CS0612
            plain.Status = await Status._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `OnlineToPlain` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In> _OnlineToPlainNoacAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain)
        {
#pragma warning disable CS0612
            plain.Status = await Status._OnlineToPlainNoacAsync();
#pragma warning restore CS0612
            return plain;
        }

        public async virtual Task PlainToOnline<T>(T plain)
        {
            await this.PlainToOnlineAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToOnlineAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain)
        {
#pragma warning disable CS0612
            await this.Status._PlainToOnlineNoacAsync(plain.Status);
#pragma warning restore CS0612
            return await this.WriteAsync<IgnoreOnPocoOperation>();
        }

        [Obsolete("This method should not be used if you indent to access the controllers data. Use `PlainToOnline` instead.")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public async Task _PlainToOnlineNoacAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain)
        {
#pragma warning disable CS0612
            await this.Status._PlainToOnlineNoacAsync(plain.Status);
#pragma warning restore CS0612
        }

        public async virtual Task<T> ShadowToPlain<T>()
        {
            return await (dynamic)this.ShadowToPlainAsync();
        }

        public async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In> ShadowToPlainAsync()
        {
            Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain = new Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In();
            plain.Status = await Status.ShadowToPlainAsync();
            return plain;
        }

        protected async Task<Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In> ShadowToPlainAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain)
        {
            plain.Status = await Status.ShadowToPlainAsync();
            return plain;
        }

        public async virtual Task PlainToShadow<T>(T plain)
        {
            await this.PlainToShadowAsync((dynamic)plain);
        }

        public async Task<IEnumerable<ITwinPrimitive>> PlainToShadowAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain)
        {
            await this.Status.PlainToShadowAsync(plain.Status);
            return this.RetrievePrimitives();
        }

        ///<inheritdoc/>
        public async virtual Task<bool> AnyChangeAsync<T>(T plain)
        {
            return await this.DetectsAnyChangeAsync((dynamic)plain);
        }

        ///<summary>
        ///Compares if the current plain object has changed from the previous object.This method is used by the framework to determine if the object has changed and needs to be updated.
        ///[!NOTE] Any member in the hierarchy that is ignored by the compilers (e.g. when CompilerOmitAttribute is used) will not be compared, and therefore will not be detected as changed.
        ///</summary>
        public async Task<bool> DetectsAnyChangeAsync(Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In plain, Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In latest = null)
        {
            if (latest == null)
                latest = await this._OnlineToPlainNoacAsync();
            var somethingChanged = false;
            return await Task.Run(async () =>
            {
                if (await Status.DetectsAnyChangeAsync(plain.Status, latest.Status))
                    somethingChanged = true;
                plain = latest;
                return somethingChanged;
            });
        }

        public void Poll()
        {
            this.RetrievePrimitives().ToList().ForEach(x => x.Poll());
        }

        public Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In CreateEmptyPoco()
        {
            return new Pocos.AXOpen.Integrations.Hwc.TemplateComponent_In();
        }

        private IList<AXSharp.Connector.ITwinObject> Children { get; } = new List<AXSharp.Connector.ITwinObject>();
        public IEnumerable<AXSharp.Connector.ITwinObject> GetChildren()
        {
            return Children;
        }

        private IList<AXSharp.Connector.ITwinElement> Kids { get; } = new List<AXSharp.Connector.ITwinElement>();
        public IEnumerable<AXSharp.Connector.ITwinElement> GetKids()
        {
            return Kids;
        }

        private IList<AXSharp.Connector.ITwinPrimitive> ValueTags { get; } = new List<AXSharp.Connector.ITwinPrimitive>();
        public IEnumerable<AXSharp.Connector.ITwinPrimitive> GetValueTags()
        {
            return ValueTags;
        }

        public void AddValueTag(AXSharp.Connector.ITwinPrimitive valueTag)
        {
            ValueTags.Add(valueTag);
        }

        public void AddKid(AXSharp.Connector.ITwinElement kid)
        {
            Kids.Add(kid);
        }

        public void AddChild(AXSharp.Connector.ITwinObject twinObject)
        {
            Children.Add(twinObject);
        }

        protected AXSharp.Connector.Connector @Connector { get; }

        public AXSharp.Connector.Connector GetConnector()
        {
            return this.@Connector;
        }

        public string GetSymbolTail()
        {
            return this.SymbolTail;
        }

        public AXSharp.Connector.ITwinObject GetParent()
        {
            return this.@Parent;
        }

        public string Symbol { get; protected set; }

        private string _attributeName;
        public System.String AttributeName { get => string.IsNullOrEmpty(_attributeName) ? SymbolTail : _attributeName.Interpolate(this).CleanUpLocalizationTokens(); set => _attributeName = value; }

        public System.String GetAttributeName(System.Globalization.CultureInfo culture)
        {
            return this.Translate(_attributeName, culture).Interpolate(this);
        }

        private string _humanReadable;
        public string HumanReadable { get => string.IsNullOrEmpty(_humanReadable) ? SymbolTail : _humanReadable.Interpolate(this).CleanUpLocalizationTokens(); set => _humanReadable = value; }

        public System.String GetHumanReadable(System.Globalization.CultureInfo culture)
        {
            return this.Translate(_humanReadable, culture);
        }

        protected System.String @SymbolTail { get; set; }

        protected AXSharp.Connector.ITwinObject @Parent { get; set; }

        public AXSharp.Connector.Localizations.Translator Interpreter => global::ix_ax_axopen_integrations_hwc.PlcTranslator.Instance;
    }
}