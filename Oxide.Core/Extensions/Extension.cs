﻿namespace Oxide.Core.Extensions
{
    /// <summary>
    /// Represents a single binary extension
    /// </summary>
    public abstract class Extension
    {
        /// <summary>
        /// Gets the name of this extension
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the author of this extension
        /// </summary>
        public abstract string Author { get; }

        /// <summary>
        /// Gets the version of this extension
        /// </summary>
        public abstract VersionNumber Version { get; }

        /// <summary>
        /// Gets whether this extension is for a specific game
        /// </summary>
        public bool IsGameExtension { get; protected set; }

        /// <summary>
        /// Gets the extension manager responsible for this extension
        /// </summary>
        public ExtensionManager Manager { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Extension class
        /// </summary>
        /// <param name="manager"></param>
        public Extension(ExtensionManager manager)
        {
            Manager = manager;
        }

        /// <summary>
        /// Loads this extension
        /// </summary>
        public virtual void Load()
        {
        }

        /// <summary>
        /// Loads any plugin watchers pertinent to this extension
        /// </summary>
        /// <param name="plugindir"></param>
        public virtual void LoadPluginWatchers(string plugindir)
        {
        }

        /// <summary>
        /// Called after all other extensions have been loaded
        /// </summary>
        /// <param name="manager"></param>
        public virtual void OnModLoad()
        {
        }
    }
}
