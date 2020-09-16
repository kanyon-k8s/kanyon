using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class Info
    {
        /** <summary></summary> */
        public string buildDate { get; set; }
        /** <summary></summary> */
        public string compiler { get; set; }
        /** <summary></summary> */
        public string gitCommit { get; set; }
        /** <summary></summary> */
        public string gitTreeState { get; set; }
        /** <summary></summary> */
        public string gitVersion { get; set; }
        /** <summary></summary> */
        public string goVersion { get; set; }
        /** <summary></summary> */
        public string major { get; set; }
        /** <summary></summary> */
        public string minor { get; set; }
        /** <summary></summary> */
        public string platform { get; set; }
    }
}