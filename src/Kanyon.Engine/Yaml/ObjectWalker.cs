using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Kanyon.Engine.Yaml
{
    public class ObjectWalker
    {
        public List<IObjectWalkStrategy> Strategies { get; set; }

        public void Walk(object o)
        {
            if (o is IEnumerable list)
            {
                foreach (var item in list)
                {
                    Walk(item);
                }
            }
            else
            {

                var properties = o.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var property in properties)
                {
                    if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string)) continue;

                    foreach (var strategy in Strategies)
                    {
                        if (strategy.CanWalk(property))
                        {
                            strategy.Walk(o, property);
                        }
                    }

                    var nextStep = property.GetValue(o);
                    if (nextStep != null)
                    {
                        Walk(nextStep);
                    }
                }
            }
        }
    }
}
