using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authorization.V1beta1
{
    public partial class SubjectAccessReviewSpec
    {
        /** <summary>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</summary> */
        public object extra { get; set; }
        /** <summary>Groups is the groups you're testing for.</summary> */
        public IEnumerable<string> group { get; set; }
        /** <summary>NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface</summary> */
        public Authorization.V1beta1.NonResourceAttributes nonResourceAttributes { get; set; }
        /** <summary>ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface</summary> */
        public Authorization.V1beta1.ResourceAttributes resourceAttributes { get; set; }
        /** <summary>UID information about the requesting user.</summary> */
        public string uid { get; set; }
        /** <summary>User is the user you're testing for. If you specify "User" but not "Group", then is it interpreted as "What if User were not a member of any groups</summary> */
        public string user { get; set; }
    }
}