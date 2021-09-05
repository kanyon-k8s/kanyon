using Kanyon.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kanyon
{
    public interface IPolicySetEvaluator
    {
        Task Evaluate(Manifest manifest, Dictionary<string, string> configuration);
    }
}