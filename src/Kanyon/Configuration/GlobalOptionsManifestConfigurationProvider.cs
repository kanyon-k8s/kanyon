﻿using Kanyon.Engine.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Configuration
{
    public class GlobalOptionsManifestConfigurationProvider : IManifestConfigurationProvider
    {
        private readonly Program program;

        public GlobalOptionsManifestConfigurationProvider(Program program)
        {
            this.program = program;
        }

        public Dictionary<string, string> Build(Dictionary<string, string> values)
        {
            values.Add("Invocation.EmitCrds", program.EmitCrds.ToString());
            values.Add("Invocation.Verbose", program.Verbose.ToString());
            values.Add("Invocation.ManifestSource", program.ManifestSource);

            return values;
        }
    }
}
