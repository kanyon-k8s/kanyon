using System;
using System.Text.RegularExpressions;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.EventEmitters;

namespace Kanyon.Yaml
{
    public class StringQuotingEmitter : ChainedEventEmitter
    {
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
                    if (val.IndexOf('\n') > -1)
                    {
                        eventInfo.Style = ScalarStyle.Literal;
                    }
                    else eventInfo.Style = ScalarStyle.DoubleQuoted;

                    break;
            }

            base.Emit(eventInfo, emitter);
        }
    }
}
