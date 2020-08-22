using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Core.V1
{
    public partial class StatusDetails
    {
        /** <summary>The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.</summary> */
        public IEnumerable<Core.V1.StatusCause> causes { get; set; }
        /** <summary>The group attribute of the resource associated with the status StatusReason.</summary> */
        public string group { get; set; }
        /** <summary>The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</summary> */
        public string name { get; set; }
        /** <summary>If specified, the time in seconds before the operation should be retried. Some errors may indicate the client must take an alternate action - for those errors this field may indicate how long to wait before taking the alternate action.</summary> */
        public int retryAfterSeconds { get; set; }
        /** <summary>UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary> */
        public string uid { get; set; }
    }
}