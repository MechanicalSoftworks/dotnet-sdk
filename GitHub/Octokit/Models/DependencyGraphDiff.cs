// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class DependencyGraphDiff : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The change_type property</summary>
        public DependencyGraphDiff_change_type? ChangeType { get; set; }
        /// <summary>The ecosystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ecosystem { get; set; }
#nullable restore
#else
        public string Ecosystem { get; set; }
#endif
        /// <summary>The license property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? License { get; set; }
#nullable restore
#else
        public string License { get; set; }
#endif
        /// <summary>The manifest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manifest { get; set; }
#nullable restore
#else
        public string Manifest { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The package_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageUrl { get; set; }
#nullable restore
#else
        public string PackageUrl { get; set; }
#endif
        /// <summary>Where the dependency is utilized. `development` means that the dependency is only utilized in the development environment. `runtime` means that the dependency is utilized at runtime and in the development environment.</summary>
        public DependencyGraphDiff_scope? Scope { get; set; }
        /// <summary>The source_repository_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceRepositoryUrl { get; set; }
#nullable restore
#else
        public string SourceRepositoryUrl { get; set; }
#endif
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>The vulnerabilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DependencyGraphDiff_vulnerabilities>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<DependencyGraphDiff_vulnerabilities> Vulnerabilities { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dependencyGraphDiff and sets the default values.
        /// </summary>
        public DependencyGraphDiff() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependencyGraphDiff CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependencyGraphDiff();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"change_type", n => { ChangeType = n.GetEnumValue<DependencyGraphDiff_change_type>(); } },
                {"ecosystem", n => { Ecosystem = n.GetStringValue(); } },
                {"license", n => { License = n.GetStringValue(); } },
                {"manifest", n => { Manifest = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"package_url", n => { PackageUrl = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetEnumValue<DependencyGraphDiff_scope>(); } },
                {"source_repository_url", n => { SourceRepositoryUrl = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<DependencyGraphDiff_vulnerabilities>(DependencyGraphDiff_vulnerabilities.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DependencyGraphDiff_change_type>("change_type", ChangeType);
            writer.WriteStringValue("ecosystem", Ecosystem);
            writer.WriteStringValue("license", License);
            writer.WriteStringValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("package_url", PackageUrl);
            writer.WriteEnumValue<DependencyGraphDiff_scope>("scope", Scope);
            writer.WriteStringValue("source_repository_url", SourceRepositoryUrl);
            writer.WriteStringValue("version", Version);
            writer.WriteCollectionOfObjectValues<DependencyGraphDiff_vulnerabilities>("vulnerabilities", Vulnerabilities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
