# Problem Statement
  
- YAML is very painful to make changes to because it isn't type-safe, relies on whitespace, and doesn't provide any validation around parameterization
- Helm provides automation around parameters, but inherits all of the pain with YAML and adds more pain with the template language obscuring the usage
- Pulumi makes the editing experience much more friendly, but requires you to set well-known things that can be included in the abstraction (like API versions, etc). It's also unclear that we could 
- CDK8S handles the editing experience well, but it relies on a scope that cross-cuts through the entire stack, and also seems to miss soem of the abstraction pieces. Parameterization is also unclear
 
# Requirements
- Repeatable - able to have a single artifact deployed through multiple different environments
- Parameterized - Each execution of that artifact should allow the process to inject values to be used in defined places
- Stateless - Should leverage the Kubernetes current state to choose how to apply changes
