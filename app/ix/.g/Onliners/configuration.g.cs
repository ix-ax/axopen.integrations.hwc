using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

public partial class app_axopen_integrations_hwcTwinController : ITwinController
{
    public AXSharp.Connector.Connector Connector { get; }

    public SandboxContext sandbox { get; }

    public DocumentationContext documentation { get; }

    public AXOpen.S71500.Rtc _rtc { get; }

    public app_axopen_integrations_hwcTwinController(AXSharp.Connector.ConnectorAdapter adapter, object[] parameters)
    {
        this.Connector = adapter.GetConnector(parameters);
        sandbox = new SandboxContext(this.Connector, "", "sandbox");
        documentation = new DocumentationContext(this.Connector, "", "documentation");
        _rtc = new AXOpen.S71500.Rtc(this.Connector, "", "_rtc");
    }

    public app_axopen_integrations_hwcTwinController(AXSharp.Connector.ConnectorAdapter adapter)
    {
        this.Connector = adapter.GetConnector(adapter.Parameters);
        sandbox = new SandboxContext(this.Connector, "", "sandbox");
        documentation = new DocumentationContext(this.Connector, "", "documentation");
        _rtc = new AXOpen.S71500.Rtc(this.Connector, "", "_rtc");
    }
}