using System.Collections.Generic;

namespace YARG.Core.Modules
{
    public class ModuleList
    {
        private readonly IList<Module> _modules;

        public ModuleList(IList<Module> modules)
        {
            _modules = modules;

            foreach (var module in _modules)
            {
                module.Initialize(this);
            }
        }

        /// <summary>
        /// Gets a module by the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the module.</typeparam>
        /// <returns>The first module that matches the specified type.</returns>
        public T Get<T>() where T : Module
        {
            foreach (var module in _modules)
            {
                if (module is T typedModule)
                {
                    return typedModule;
                }
            }

            return null;
        }
    }
}