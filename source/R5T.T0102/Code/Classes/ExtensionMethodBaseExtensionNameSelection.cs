using System;

using R5T.T0092;
using R5T.T0092.X001;


namespace R5T.T0102
{
    public class ExtensionMethodBaseExtensionNameSelection : INamedIdentified
    {
        public Guid ExtensionMethodBaseExtensionIdentity { get; set; }
        public string ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName { get; set; }

        string INamed.Name => this.ExtensionMethodBaseExtensionNamespacedTypedParameterizedMethodName;
        Guid IIdentified.Identity => this.ExtensionMethodBaseExtensionIdentity;


        public override string ToString()
        {
            var representation = this.ToStringRepresentation();
            return representation;
        }
    }
}
