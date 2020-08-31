using Kapitan.Kubernetes.Core.V1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitan.Kubernetes.Fluent.Core.V1
{
    public static class ProbeExtensions
    {
        public static Probe WithFailureThreshold(this Probe probe, int failureThreshold)
        {
            probe.failureThreshold = failureThreshold;
            return probe;
        }

        public static Probe WithInitialDelaySeconds(this Probe probe, int initialDelaySeconds)
        {
            probe.initialDelaySeconds = initialDelaySeconds;
            return probe;
        }

        public static Probe WithPeriodSeconds(this Probe probe, int periodSeconds)
        {
            probe.periodSeconds = periodSeconds;
            return probe;
        }

        public static Probe WithSuccessThreshold(this Probe probe, int successThreshold)
        {
            probe.successThreshold = successThreshold;
            return probe;
        }

        public static Probe WithTimeoutSeconds(this Probe probe, int timeoutSeconds)
        {
            probe.timeoutSeconds = timeoutSeconds;
            return probe;
        }

        public static HTTPGetAction WithHttpGetAction(this Probe probe)
        {
            probe.httpGet = new HTTPGetAction();
            return probe.httpGet;
        }
    }
}
