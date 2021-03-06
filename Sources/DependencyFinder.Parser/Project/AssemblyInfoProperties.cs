﻿using System;

namespace ByteDev.DotNet.Project
{
    /// <summary>
    /// Represents assembly info properties for the .NET project file.
    /// </summary>
    public class AssemblyInfoProperties
    {
        private readonly Lazy<string> _company;
        private readonly Lazy<string> _configuration;
        private readonly Lazy<string> _copyright;
        private readonly Lazy<string> _description;
        private readonly Lazy<string> _fileVersion;
        private readonly Lazy<string> _informationalVersion;
        private readonly Lazy<string> _product;
        private readonly Lazy<string> _assemblyTitle;
        private readonly Lazy<string> _assemblyVersion;
        private readonly Lazy<string> _neutralLanguage;
        private readonly Lazy<string> _assemblyName;

        internal AssemblyInfoProperties(PropertyGroupCollection propertyGroupCollection)
        {
            if (propertyGroupCollection == null)
                throw new ArgumentNullException(nameof(propertyGroupCollection));

            _company = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("Company"));
            _configuration = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("Configuration"));
            _copyright = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("Copyright"));
            _description = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("Description"));
            _fileVersion = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("FileVersion"));
            _informationalVersion = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("InformationalVersion"));
            _product = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("Product"));
            _assemblyTitle = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("AssemblyTitle"));
            _assemblyVersion = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("AssemblyVersion"));
            _neutralLanguage = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("NeutralLanguage"));
            _assemblyName = new Lazy<string>(() => propertyGroupCollection.GetElementValue2("AssemblyName"));
        }

        /// <summary>
        /// Specifies company name for assembly manifest.
        /// </summary>
        public string Company => _company.Value;

        /// <summary>
        /// Specifies the build configuration, such as retail or debug, for an assembly.
        /// </summary>
        public string Configuration => _configuration.Value;

        /// <summary>
        /// Copyright information for assembly manifest.
        /// </summary>
        public string Copyright => _copyright.Value;

        /// <summary>
        /// Text description for the assembly.
        /// </summary>
        public string Description => _description.Value;

        /// <summary>
        /// File version that instructs a compiler to use a specific version number for the Win32 file version resource.
        /// The Win32 file version is not required to be the same as the assembly's version number.
        /// </summary>
        public string FileVersion => _fileVersion.Value;

        /// <summary>
        /// Defines additional version information for an assembly manifest.
        /// </summary>
        public string InformationalVersion => _informationalVersion.Value;

        /// <summary>
        /// Defines a product name for an assembly manifest.
        /// </summary>
        public string Product => _product.Value;

        /// <summary>
        /// Specifies a title description for an assembly.
        /// </summary>
        public string Title => _assemblyTitle.Value;

        /// <summary>
        /// Specifies the assembly version.
        /// </summary>
        public string Version => _assemblyVersion.Value;

        /// <summary>
        /// Informs the resource manager of an app's default culture.
        /// </summary>
        public string NeutralLanguage => _neutralLanguage.Value;

        public string AssemblyName => _assemblyName.Value;
    }
}