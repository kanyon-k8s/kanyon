using System;
using System.Runtime.Serialization;

namespace Kanyon.Engine.Loaders
{
    [Serializable]
    internal class MissingManifestException : Exception
    {
        public MissingManifestException()
        {
        }

        public MissingManifestException(string message) : base(message)
        {
        }

        public MissingManifestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingManifestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}