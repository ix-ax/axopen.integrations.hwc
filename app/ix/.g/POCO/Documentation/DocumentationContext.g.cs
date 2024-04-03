using System;

namespace Pocos
{
    public partial class DocumentationContext : AXOpen.Core.AxoContext, AXSharp.Connector.IPlain
    {
        public Component_1 componentOne { get; set; } = new Component_1();
        public Component_2 componentTwo { get; set; } = new Component_2();
    }
}