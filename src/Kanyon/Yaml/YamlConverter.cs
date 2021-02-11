using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Kanyon.Yaml
{
    public static class YamlConverter
    {
        public static string SerializeObject(object value)
        {
            var stringBuilder = new StringBuilder();
            var writer = new StringWriter(stringBuilder);
            var emitter = new Emitter(writer);

            // This allows an extension point to walk through the object graph and make serialization fixups. This is primarily driven by the OpenAPI serialization, and if we can find a better way
            // to manage that process, this can be replaced as it's not easily extensible
            var walker = new ObjectWalker() { Strategies = new List<IObjectWalkStrategy> { new EmptyEnumerableWalkStrategy() } };
            walker.Walk(value);

            var serializer =
                new SerializerBuilder()
                    .DisableAliases()
                    .WithNamingConvention(new CamelCaseNamingConvention())
                    .WithTypeInspector(ti => new AutoRestTypeInspector(ti))
                    .WithTypeConverter(new WrappedStringYamlConverter())
                    .WithEventEmitter(e => new StringQuotingEmitter(e))
                    .WithAttributeOverride<OpenApiSchema>(s => s.AdditionalPropertiesAllowed, new YamlIgnoreAttribute())
                    .BuildValueSerializer();
            emitter.Emit(new StreamStart());
            emitter.Emit(new DocumentStart());
            serializer.SerializeValue(emitter, value, value.GetType());

            return stringBuilder.ToString();
        }
    }
}
