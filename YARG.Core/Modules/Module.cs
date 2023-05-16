namespace YARG.Core.Modules
{
    public abstract class Module
    {
        protected ModuleList Modules { get; private set; }

        /// <summary>
        /// Initializes the module.
        /// </summary>
        /// <param name="modules">
        /// The <see cref="ModuleList"/> that this module is a part of
        /// </param>
        public void Initialize(ModuleList modules)
        {
            Modules = modules;
            OnInitialize();
        }

        /// <summary>
        /// Called when the module should be initialized.
        /// </summary>
        protected abstract void OnInitialize();
    }
}