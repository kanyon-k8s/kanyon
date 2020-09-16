using Scriban;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanyon.ResourceGenerator
{
    public class ClassGenerator
    {
        private readonly DirectoryInfo root;
        private Template subobjectTemplate;
        private Template kubernetesObjectTemplate;
        private Template enumTemplate;

        public static List<string> BaseObjectIgnoredProperties = new List<string> { "apiVersion", "kind", "status" };

        public ClassGenerator(DirectoryInfo root)
        {
            this.root = root;
        }

        public async Task InitializeAsync()
        {
            subobjectTemplate = await LoadTemplate("SubObject.scriban");
            kubernetesObjectTemplate = await LoadTemplate("KubernetesObject.scriban");
            enumTemplate = await LoadTemplate("EnumObject.scriban");
        }

        public async Task<Template> LoadTemplate(string file)
        {
            string content = await File.ReadAllTextAsync(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file));
            return Template.Parse(content);
        }

        public async Task WriteCodeFileAsync(ApiTypeDefinition typedef)
        {
            if (typedef.TypeName == "JSONSchemaProps")
            {
                return;
            }

            if (kubernetesObjectTemplate == null) throw new InvalidOperationException("InitializeAsync must be called before any code files can be written");

            var template = subobjectTemplate;
            if (typedef.IsManifestObject)
            {
                template = kubernetesObjectTemplate;
                typedef.PropertyDefinitions = typedef.PropertyDefinitions.SkipWhile(pd => BaseObjectIgnoredProperties.Contains(pd.Name));
            }
            if (typedef.IsEnumObject)
            {
                template = enumTemplate;
            }

            // Add rules execution engine

            var content = await template.RenderAsync(typedef, member => member.Name);

            var directory = string.IsNullOrWhiteSpace(typedef.Directory) ? root : root.CreateSubdirectory(typedef.Directory);

            File.WriteAllText(Path.Combine(directory.FullName, $"{typedef.TypeName}.generated.cs"), content);
        }
    }
}
