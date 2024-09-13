// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.CodeSecurity.Configurations
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ConfigurationsPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The enablement status of GitHub Advanced Security</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_advanced_security? AdvancedSecurity { get; set; }
        /// <summary>The enablement status of code scanning default setup</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_code_scanning_default_setup? CodeScanningDefaultSetup { get; set; }
        /// <summary>The enablement status of Dependabot alerts</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_alerts? DependabotAlerts { get; set; }
        /// <summary>The enablement status of Dependabot security updates</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_security_updates? DependabotSecurityUpdates { get; set; }
        /// <summary>The enablement status of Dependency Graph</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph? DependencyGraph { get; set; }
        /// <summary>The enablement status of Automatic dependency submission</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action? DependencyGraphAutosubmitAction { get; set; }
        /// <summary>Feature options for Automatic dependency submission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options? DependencyGraphAutosubmitActionOptions { get; set; }
#nullable restore
#else
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options DependencyGraphAutosubmitActionOptions { get; set; }
#endif
        /// <summary>A description of the code security configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The enforcement status for a security configuration</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_enforcement? Enforcement { get; set; }
        /// <summary>The name of the code security configuration. Must be unique within the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The enablement status of private vulnerability reporting</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_private_vulnerability_reporting? PrivateVulnerabilityReporting { get; set; }
        /// <summary>The enablement status of secret scanning</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning? SecretScanning { get; set; }
        /// <summary>The enablement status of secret scanning non provider patterns</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_non_provider_patterns? SecretScanningNonProviderPatterns { get; set; }
        /// <summary>The enablement status of secret scanning push protection</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_push_protection? SecretScanningPushProtection { get; set; }
        /// <summary>The enablement status of secret scanning validity checks</summary>
        public global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_validity_checks? SecretScanningValidityChecks { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody"/> and sets the default values.
        /// </summary>
        public ConfigurationsPostRequestBody()
        {
            AdvancedSecurity = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_advanced_security.Disabled;
            CodeScanningDefaultSetup = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_code_scanning_default_setup.Disabled;
            DependabotAlerts = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_alerts.Disabled;
            DependabotSecurityUpdates = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_security_updates.Disabled;
            DependencyGraph = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph.Enabled;
            DependencyGraphAutosubmitAction = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action.Disabled;
            Enforcement = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_enforcement.Enforced;
            PrivateVulnerabilityReporting = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_private_vulnerability_reporting.Disabled;
            SecretScanning = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning.Disabled;
            SecretScanningNonProviderPatterns = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_non_provider_patterns.Disabled;
            SecretScanningPushProtection = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_push_protection.Disabled;
            SecretScanningValidityChecks = global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_validity_checks.Disabled;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security", n => { AdvancedSecurity = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_advanced_security>(); } },
                { "code_scanning_default_setup", n => { CodeScanningDefaultSetup = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_code_scanning_default_setup>(); } },
                { "dependabot_alerts", n => { DependabotAlerts = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_alerts>(); } },
                { "dependabot_security_updates", n => { DependabotSecurityUpdates = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_security_updates>(); } },
                { "dependency_graph", n => { DependencyGraph = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph>(); } },
                { "dependency_graph_autosubmit_action", n => { DependencyGraphAutosubmitAction = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action>(); } },
                { "dependency_graph_autosubmit_action_options", n => { DependencyGraphAutosubmitActionOptions = n.GetObjectValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options>(global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "enforcement", n => { Enforcement = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_enforcement>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "private_vulnerability_reporting", n => { PrivateVulnerabilityReporting = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_private_vulnerability_reporting>(); } },
                { "secret_scanning", n => { SecretScanning = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning>(); } },
                { "secret_scanning_non_provider_patterns", n => { SecretScanningNonProviderPatterns = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_non_provider_patterns>(); } },
                { "secret_scanning_push_protection", n => { SecretScanningPushProtection = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_push_protection>(); } },
                { "secret_scanning_validity_checks", n => { SecretScanningValidityChecks = n.GetEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_validity_checks>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_advanced_security>("advanced_security", AdvancedSecurity);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_code_scanning_default_setup>("code_scanning_default_setup", CodeScanningDefaultSetup);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_alerts>("dependabot_alerts", DependabotAlerts);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependabot_security_updates>("dependabot_security_updates", DependabotSecurityUpdates);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph>("dependency_graph", DependencyGraph);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action>("dependency_graph_autosubmit_action", DependencyGraphAutosubmitAction);
            writer.WriteObjectValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_dependency_graph_autosubmit_action_options>("dependency_graph_autosubmit_action_options", DependencyGraphAutosubmitActionOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_enforcement>("enforcement", Enforcement);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_private_vulnerability_reporting>("private_vulnerability_reporting", PrivateVulnerabilityReporting);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning>("secret_scanning", SecretScanning);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_non_provider_patterns>("secret_scanning_non_provider_patterns", SecretScanningNonProviderPatterns);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_push_protection>("secret_scanning_push_protection", SecretScanningPushProtection);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.CodeSecurity.Configurations.ConfigurationsPostRequestBody_secret_scanning_validity_checks>("secret_scanning_validity_checks", SecretScanningValidityChecks);
        }
    }
}
#pragma warning restore CS0618
