using System;
using System.Reflection;

namespace Kanyon.Engine.Yaml
{
    public interface IObjectWalkStrategy
    {
        bool CanWalk(PropertyInfo info);
        void Walk(object o, PropertyInfo pi);
    }
}
