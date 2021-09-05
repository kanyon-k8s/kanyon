using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Kanyon.Engine.Yaml
{
    public class AdditionalPropertiesFixingWalkStrategy : IObjectWalkStrategy
    {
        public bool CanWalk(PropertyInfo info)
        {
            return info.PropertyType == typeof(OpenApiSchema);
        }

        public void Walk(object o, PropertyInfo pi)
        {
            var schema = pi.GetValue(o) as OpenApiSchema;
            if (schema == null) return;

            schema.AdditionalPropertiesAllowed = schema.AdditionalProperties != null;
        }
    }
}
