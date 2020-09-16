using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authorization.V1beta1
{
    public partial class SubjectAccessReviewStatus
    {
        /** <summary>Allowed is required. True if the action would be allowed, false otherwise.</summary> */
        public bool allowed { get; set; }
        /** <summary>Denied is optional. True if the action would be denied, otherwise false. If both allowed is false and denied is false, then the authorizer has no opinion on whether to authorize the action. Denied may not be true if Allowed is true.</summary> */
        public bool denied { get; set; }
        /** <summary>EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.</summary> */
        public string evaluationError { get; set; }
        /** <summary>Reason is optional.  It indicates why a request was allowed or denied.</summary> */
        public string reason { get; set; }
    }
}