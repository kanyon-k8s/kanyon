using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Flowcontrol.V1alpha1
{
    public partial class PolicyRulesWithSubjects
    {
        /** <summary>`nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.</summary> */
        public List<Flowcontrol.V1alpha1.NonResourcePolicyRule> nonResourceRules { get; set; }
        /** <summary>`resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource. At least one of `resourceRules` and `nonResourceRules` has to be non-empty.</summary> */
        public List<Flowcontrol.V1alpha1.ResourcePolicyRule> resourceRules { get; set; }
        /** <summary>subjects is the list of normal user, serviceaccount, or group that this rule cares about. There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.</summary> */
        public List<Flowcontrol.V1alpha1.Subject> subjects { get; set; }
    }
}