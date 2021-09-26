using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.Core.V1
{
    public partial class PortStatus
    {
        /** <summary>Error is to record the problem with the service port The format of the error shall comply with the following rules: - built-in error values shall be specified in this file and those shall use
  CamelCase names
- cloud provider specific error values must have names that comply with the
  format foo.example.com/CamelCase.</summary> */
        public string error { get; set; }
        /** <summary>Port is the port number of the service port of which status is recorded here</summary> */
        public int port { get; set; }
        /** <summary>Protocol is the protocol of the service port of which status is recorded here The supported values are: "TCP", "UDP", "SCTP"</summary> */
        public string protocol { get; set; }
    }
}