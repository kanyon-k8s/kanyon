using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class NodeConfigStatus
    {
        /** <summary>NodeConfigSource specifies a source of node configuration. Exactly one subfield (excluding metadata) must be non-nil. This API is deprecated since 1.22</summary> */
        public Core.V1.NodeConfigSource active { get; set; }
        /** <summary>NodeConfigSource specifies a source of node configuration. Exactly one subfield (excluding metadata) must be non-nil. This API is deprecated since 1.22</summary> */
        public Core.V1.NodeConfigSource assigned { get; set; }
        /** <summary>Error describes any problems reconciling the Spec.ConfigSource to the Active config. Errors may occur, for example, attempting to checkpoint Spec.ConfigSource to the local Assigned record, attempting to checkpoint the payload associated with Spec.ConfigSource, attempting to load or validate the Assigned config, etc. Errors may occur at different points while syncing config. Earlier errors (e.g. download or checkpointing errors) will not result in a rollback to LastKnownGood, and may resolve across Kubelet retries. Later errors (e.g. loading or validating a checkpointed config) will result in a rollback to LastKnownGood. In the latter case, it is usually possible to resolve the error by fixing the config assigned in Spec.ConfigSource. You can find additional information for debugging by searching the error message in the Kubelet log. Error is a human-readable description of the error state; machines can check whether or not Error is empty, but should not rely on the stability of the Error text across Kubelet versions.</summary> */
        public string error { get; set; }
        /** <summary>NodeConfigSource specifies a source of node configuration. Exactly one subfield (excluding metadata) must be non-nil. This API is deprecated since 1.22</summary> */
        public Core.V1.NodeConfigSource lastKnownGood { get; set; }
    }
}