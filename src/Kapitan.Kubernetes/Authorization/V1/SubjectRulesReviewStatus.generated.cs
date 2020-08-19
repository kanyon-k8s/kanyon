using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Authorization.V1
{
    public partial class SubjectRulesReviewStatus
    {
        /** <summary>EvaluationError can appear in combination with Rules. It indicates an error occurred during rule evaluation, such as an authorizer that doesn't support rule evaluation, and that ResourceRules and/or NonResourceRules may be incomplete.</summary> */
        public string evaluationError { get; set; }
        /** <summary>Incomplete is true when the rules returned by this call are incomplete. This is most commonly encountered when an authorizer, such as an external authorizer, doesn't support rules evaluation.</summary> */
        public bool incomplete { get; set; }
        /** <summary>NonResourceRules is the list of actions the subject is allowed to perform on non-resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary> */
        public List<Authorization.V1.NonResourceRule> nonResourceRules { get; set; }
        /** <summary>ResourceRules is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary> */
        public List<Authorization.V1.ResourceRule> resourceRules { get; set; }
    }
}