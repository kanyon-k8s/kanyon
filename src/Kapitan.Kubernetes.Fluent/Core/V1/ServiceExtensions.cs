using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Core.V1
{
    public static class ServiceExtensions
    {
        public static Service WithSelector(this Service service, string key, string value)
        {
            if (service.spec.selector == null) service.spec.selector = new Dictionary<string, string>();
            var selectors = service.spec.selector as Dictionary<string, string>;
            if (selectors == null) throw new InvalidOperationException("Selectors can only be added to a dictionary");

            selectors.Add(key, value);

            return service;
        }

        public static Service WithPort(this Service service, int port, string name = null, string protocol = null, IntOrString targetPort = null, string appProtocol = null)
        {
            var list = service.spec.ports?.ToList() ?? new List<ServicePort>();
            list.Add(new ServicePort()
            {
                port = port,
                name = name,
                protocol = protocol,
                targetPort = targetPort,
                appProtocol = appProtocol,
            });

            service.spec.ports = list;

            return service;
        }

        public static Service WithType(this Service service, string type)
        {
            service.spec.type = type;
            return service;
        }
    }

    public static class Services
    {
        public static Service Service()
        {
            return new Service
            {
                metadata = new ObjectMeta(),
                spec = new ServiceSpec()
            };
        }
    }
}
