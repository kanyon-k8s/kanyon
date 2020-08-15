﻿using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Kapitan.Yaml
{
    public static class YamlConverter
    {
        public static string SerializeObject(object value)
        {
            var stringBuilder = new StringBuilder();
            var writer = new StringWriter(stringBuilder);
            var emitter = new Emitter(writer);

            var serializer =
                new SerializerBuilder()
                    .DisableAliases()
                    .WithNamingConvention(new CamelCaseNamingConvention())
                    .WithTypeInspector(ti => new AutoRestTypeInspector(ti))
                    .WithTypeConverter(new IntOrStringYamlConverter())
                    .WithEventEmitter(e => new StringQuotingEmitter(e))
                    .BuildValueSerializer();
            emitter.Emit(new StreamStart());
            emitter.Emit(new DocumentStart());
            serializer.SerializeValue(emitter, value, value.GetType());

            return stringBuilder.ToString();
        }
    }
}