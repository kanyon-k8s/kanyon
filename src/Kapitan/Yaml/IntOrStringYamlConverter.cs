using Kapitan.Kubernetes;
using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace Kapitan.Yaml
{
    public class IntOrStringYamlConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(IntOrString);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            if (parser.Current is Scalar scalar)
            {
                try
                {
                    return new IntOrString(scalar.Value);
                }
                finally
                {
                    parser.MoveNext();
                }
            }

            throw new InvalidOperationException(parser.Current?.ToString());
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            var obj = (IntOrString)value;
            emitter.Emit(new Scalar(obj.Value));
        }
    }
}
