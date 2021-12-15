using System;

using R5T.T0092;
using R5T.T0092.X001;
using R5T.T0093;
using R5T.T0094;


namespace R5T.T0102
{
    public class ExtensionMethodBaseExtension : IMutableIdentified, INamedIdentifiedFilePathed
    {
        public Guid Identity { get; set; }

        public string NamespacedTypedParameterizedMethodName { get; set; }
        public string CodeFilePath { get; set; } // Used for later identification of the containing project.

        string INamed.Name => this.NamespacedTypedParameterizedMethodName;
        string IFilePathed.FilePath => this.CodeFilePath;


        public override string ToString()
        {
            var representation = this.ToStringRepresentation();
            return representation;
        }
    }
}
