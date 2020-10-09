using System.Collections.Generic;

namespace Kanyon.Core
{
    public interface IHelpTextProvider
    {
        IEnumerable<HelpText> GetHelpText();
    }
}
