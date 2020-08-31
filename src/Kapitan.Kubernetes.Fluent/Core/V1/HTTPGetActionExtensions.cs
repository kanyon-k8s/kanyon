using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Core.V1
{
    public static class HTTPGetActionExtensions
    {
        public static HTTPGetAction WithHost(this HTTPGetAction action, string host)
        {
            action.host = host;
            return action;
        }

        public static HTTPGetAction WithPath(this HTTPGetAction action, string path)
        {
            action.path = path;
            return action;
        }

        public static HTTPGetAction WithPort(this HTTPGetAction action, IntOrString port)
        {
            action.port = port;
            return action;
        }

        public static HTTPGetAction WithScheme(this HTTPGetAction action, string scheme)
        {
            action.scheme = scheme;
            return action;
        }

        public static HTTPGetAction WithHeader(this HTTPGetAction action, string header, string value)
        {
            var list = action.httpHeaders?.ToList() ?? new List<HTTPHeader>();
            list.Add(new HTTPHeader { name = header, value = value });

            action.httpHeaders = list;
            return action;
        }
    }
}
