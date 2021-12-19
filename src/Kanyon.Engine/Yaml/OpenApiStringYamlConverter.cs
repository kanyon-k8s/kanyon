using Kanyon.Core;
using Microsoft.OpenApi.Any;
using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace Kanyon.Engine.Yaml
{
    public class OpenApiStringYamlConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return typeof(OpenApiString).IsAssignableFrom(type);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            if (parser.Current is Scalar scalar)
            {
                try
                {
                    return Activator.CreateInstance(type, scalar.Value);
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
            var obj = (OpenApiString)value;
            emitter.Emit(new Scalar(obj.Value));
        }
    }
}
