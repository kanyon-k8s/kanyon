using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class OwnerReference
    {
        /** <summary>API version of the referent.</summary> */
        public string apiVersion { get; set; }
        /** <summary>If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot be deleted from the key-value store until this reference is removed. Defaults to false. To set this field, a user needs "delete" permission of the owner, otherwise 422 (Unprocessable Entity) will be returned.</summary> */
        public bool blockOwnerDeletion { get; set; }
        /** <summary>If true, this reference points to the managing controller.</summary> */
        public bool controller { get; set; }
        /** <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary> */
        public string name { get; set; }
        /** <summary>UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary> */
        public string uid { get; set; }
    }
}