// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ActionsOrganizationPermissions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The permissions policy that controls the actions and reusable workflows that are allowed to run.</summary>
        public global::GitHub.Models.AllowedActions? AllowedActions { get; set; }
        /// <summary>The policy that controls the repositories in the organization that are allowed to run GitHub Actions.</summary>
        public global::GitHub.Models.EnabledRepositories? EnabledRepositories { get; set; }
        /// <summary>The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectedActionsUrl { get; set; }
#nullable restore
#else
        public string SelectedActionsUrl { get; set; }
#endif
        /// <summary>The API URL to use to get or set the selected repositories that are allowed to run GitHub Actions, when `enabled_repositories` is set to `selected`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectedRepositoriesUrl { get; set; }
#nullable restore
#else
        public string SelectedRepositoriesUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ActionsOrganizationPermissions"/> and sets the default values.
        /// </summary>
        public ActionsOrganizationPermissions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ActionsOrganizationPermissions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ActionsOrganizationPermissions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ActionsOrganizationPermissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowed_actions", n => { AllowedActions = n.GetEnumValue<global::GitHub.Models.AllowedActions>(); } },
                { "enabled_repositories", n => { EnabledRepositories = n.GetEnumValue<global::GitHub.Models.EnabledRepositories>(); } },
                { "selected_actions_url", n => { SelectedActionsUrl = n.GetStringValue(); } },
                { "selected_repositories_url", n => { SelectedRepositoriesUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::GitHub.Models.AllowedActions>("allowed_actions", AllowedActions);
            writer.WriteEnumValue<global::GitHub.Models.EnabledRepositories>("enabled_repositories", EnabledRepositories);
            writer.WriteStringValue("selected_actions_url", SelectedActionsUrl);
            writer.WriteStringValue("selected_repositories_url", SelectedRepositoriesUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
