using System;

using R5T.T0101;


namespace R5T.T0102
{
    public class ExtensionMethodBaseExtensionToExtensionMethodBaseMapping : IIdentityMapping
    {
        public Guid ExtensionMethodBaseExtensionIdentity { get; set; }
        public Guid ExtensionMethodBaseIdentity { get; set; }

        Guid ITypedIdentityMapping<Guid, Guid>.LocalIdentity
        {
            get
            {
                return this.ExtensionMethodBaseExtensionIdentity;
            }
            set
            {
                this.ExtensionMethodBaseExtensionIdentity = value;
            }
        }

        Guid ITypedIdentityMapping<Guid, Guid>.ExternalIdentity
        {
            get
            {
                return this.ExtensionMethodBaseIdentity;
            }
            set
            {
                this.ExtensionMethodBaseIdentity = value;
            }
        }
    }
}
