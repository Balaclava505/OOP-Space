using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CircleMovement.Compression
{
    public class CompressionAlgs
    {
        public List<ICompression> objects;

        private string[] dllFileNames;
        private List<Assembly> assemblies;
        private List<Type> pluginTypes;

        public CompressionAlgs(string path)
        {
            GetFiles(path);

            GetAssemblies();

            GetPluginTypes();

            CreatePluginList();
        }

        private void GetFiles(string path)
        {
            if (Directory.Exists(path))
            {
                dllFileNames = Directory.GetFiles(path, "*.dll");
            }
        }

        private void GetAssemblies()
        {
            assemblies = new List<Assembly>(dllFileNames.Length);

            foreach (string dllFile in dllFileNames)
            {
                AssemblyName name = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(name);
                assemblies.Add(assembly);
            }
        }

        private void GetPluginTypes()
        {
            Type pluginType = typeof(ICompression);
            pluginTypes = new List<Type>();

            foreach (Assembly assembly in assemblies)
            {
                if (assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                        {
                            continue;
                        }
                        else
                        {
                            if (type.GetInterface(pluginType.FullName) != null)
                            {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }
            }
        }

        private void CreatePluginList()
        {
            objects = new List<ICompression>(pluginTypes.Count);

            foreach (Type type in pluginTypes)
            {
                ICompression plugin = (ICompression)Activator.CreateInstance(type);
                objects.Add(plugin);
            }
        }
    }
}
