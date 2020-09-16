using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Authentication.V1beta1
{
    public partial class UserInfo
    {
        /** <summary>Any additional information provided by the authenticator.</summary> */
        public object extra { get; set; }
        /** <summary>The names of groups this user is a part of.</summary> */
        public IEnumerable<string> groups { get; set; }
        /** <summary>A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.</summary> */
        public string uid { get; set; }
        /** <summary>The name that uniquely identifies this user among all active users.</summary> */
        public string username { get; set; }
    }
}