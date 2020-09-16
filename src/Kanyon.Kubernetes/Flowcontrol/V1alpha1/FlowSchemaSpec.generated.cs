using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class FlowSchemaSpec
    {
        /** <summary>FlowDistinguisherMethod specifies the method of a flow distinguisher.</summary> */
        public Flowcontrol.V1alpha1.FlowDistinguisherMethod distinguisherMethod { get; set; }
        /** <summary>`matchingPrecedence` is used to choose among the FlowSchemas that match a given request. The chosen FlowSchema is among those with the numerically lowest (which we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence value must be ranged in [1,10000]. Note that if the precedence is not specified, it will be set to 1000 as default.</summary> */
        public int matchingPrecedence { get; set; }
        /** <summary>PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.</summary> */
        public Flowcontrol.V1alpha1.PriorityLevelConfigurationReference priorityLevelConfiguration { get; set; }
        /** <summary>`rules` describes which requests will match this flow schema. This FlowSchema matches a request if and only if at least one member of rules matches the request. if it is an empty slice, there will be no requests matching the FlowSchema.</summary> */
        public IEnumerable<Flowcontrol.V1alpha1.PolicyRulesWithSubjects> rules { get; set; }
    }
}