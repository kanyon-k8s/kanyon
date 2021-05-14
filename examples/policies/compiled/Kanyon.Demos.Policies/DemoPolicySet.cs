using Kanyon.Core;


/* This assembly attribute is optional. It allows multiple policy sets to be defined in a single DLL and be referenced by name.
   If there is only one PolicySet superclass, then no attribute is needed. If there are multiple classes descending from PolicySet, 
   you must add a --policy-set parameter at runtime that matches one policy set
*/

[assembly: KanyonPolicySet(typeof(Kanyon.Demos.Policies.DemoPolicySet), Name = "Demo")]
namespace Kanyon.Demos.Policies
{
    public class DemoPolicySet : PolicySet 
    {
        public DemoPolicySet()
        {
            Add(new EnforcePullPolicyPolicy());
            Add(new AnnotateObjectsPolicy());
        }
    }
}