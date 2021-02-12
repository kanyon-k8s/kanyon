using System;
using System.Text.RegularExpressions;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.EventEmitters;

namespace Kanyon.Yaml
{
    public class StringQuotingEmitter : ChainedEventEmitter
    {
        // Patterns from https://yaml.org/spec/1.2/spec.html#id2804356
        private static readonly Regex QuotedRegex =
            new Regex(@"^(\~|null|true|false|y|Y|n|N|off|on|-?(0|[1-9][0-9]*)(\.[0-9]*)?([eE][-+]?[0-9]+)?)?$");

        public StringQuotingEmitter(IEventEmitter next)
            : base(next)
        {
        }

        /// <inheritdoc/>
        public override void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
        {
            var typeCode = eventInfo?.Source.Value != null
                ? Type.GetTypeCode(eventInfo.Source.Type)
                : TypeCode.Empty;
            switch (typeCode)
            {
                case TypeCode.Char:
                    if (char.IsDigit((char)eventInfo.Source.Value))
                    {
                        eventInfo.Style = ScalarStyle.DoubleQuoted;
                    }

                    break;
                case TypeCode.String:
                    var val = eventInfo.Source.Value.ToString();
                    if (QuotedRegex.IsMatch(val))
                    {
                        eventInfo.Style = ScalarStyle.DoubleQuoted;
                    }
                    else if (val.IndexOf('\n') > -1)
                    {
                        eventInfo.Style = ScalarStyle.Literal;
                    }

                    break;
            }

            base.Emit(eventInfo, emitter);
        }
    }
}
