using Scriban;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitan.ResourceGenerator
{
    public class ClassGenerator
    {
        private readonly DirectoryInfo root;
        private Template subobjectTemplate;
        private Template kubernetesObjectTemplate;

        public static List<string> BaseObjectIgnoredProperties = new List<string> { "apiVersion", "kind", "status" };

        public ClassGenerator(DirectoryInfo root)
        {
            this.root = root;
        }

        public async Task InitializeAsync()
        {
            subobjectTemplate = await LoadTemplate("SubObject.scriban");
            kubernetesObjectTemplate = await LoadTemplate("KubernetesObject.scriban");
        }

        public async Task<Template> LoadTemplate(string file)
        {
            string content = await File.ReadAllTextAsync(file);
            return Template.Parse(content);
        }

        public async Task WriteCodeFileAsync(ApiTypeDefinition typedef)
        {
            if (kubernetesObjectTemplate == null) throw new InvalidOperationException("InitializeAsync must be called before any code files can be written");

            var template = subobjectTemplate;
            if (typedef.Schema.Extensions.ContainsKey("x-kubernetes-group-version-kind"))
            {
                template = kubernetesObjectTemplate;
                typedef.PropertyDefinitions = typedef.PropertyDefinitions.SkipWhile(pd => BaseObjectIgnoredProperties.Contains(pd.Name));
            }

            var content = await template.RenderAsync(typedef, member => member.Name);

            var directory = string.IsNullOrWhiteSpace(typedef.Directory) ? root : root.CreateSubdirectory(typedef.Directory);

            File.WriteAllText(Path.Combine(directory.FullName, $"{typedef.TypeName}.generated.cs"), content);
        }
    }
}
