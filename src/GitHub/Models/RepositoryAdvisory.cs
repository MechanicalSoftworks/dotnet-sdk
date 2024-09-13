// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// A repository security advisory.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RepositoryAdvisory : IParsable
    {
        /// <summary>The author of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleUser? Author { get; private set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleUser Author { get; private set; }
#endif
        /// <summary>The date and time of when the advisory was closed, in ISO 8601 format.</summary>
        public DateTimeOffset? ClosedAt { get; private set; }
        /// <summary>A list of teams that collaborate on the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Team>? CollaboratingTeams { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Team> CollaboratingTeams { get; set; }
#endif
        /// <summary>A list of users that collaborate on the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.SimpleUser>? CollaboratingUsers { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.SimpleUser> CollaboratingUsers { get; set; }
#endif
        /// <summary>The date and time of when the advisory was created, in ISO 8601 format.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The credits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.RepositoryAdvisory_credits>? Credits { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.RepositoryAdvisory_credits> Credits { get; set; }
#endif
        /// <summary>The credits_detailed property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.RepositoryAdvisoryCredit>? CreditsDetailed { get; private set; }
#nullable restore
#else
        public List<global::GitHub.Models.RepositoryAdvisoryCredit> CreditsDetailed { get; private set; }
#endif
        /// <summary>The Common Vulnerabilities and Exposures (CVE) ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CveId { get; set; }
#nullable restore
#else
        public string CveId { get; set; }
#endif
        /// <summary>The cvss property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.RepositoryAdvisory_cvss? Cvss { get; set; }
#nullable restore
#else
        public global::GitHub.Models.RepositoryAdvisory_cvss Cvss { get; set; }
#endif
        /// <summary>A list of only the CWE IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CweIds { get; set; }
#nullable restore
#else
        public List<string> CweIds { get; set; }
#endif
        /// <summary>The cwes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.RepositoryAdvisory_cwes>? Cwes { get; private set; }
#nullable restore
#else
        public List<global::GitHub.Models.RepositoryAdvisory_cwes> Cwes { get; private set; }
#endif
        /// <summary>A detailed description of what the advisory entails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The GitHub Security Advisory ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GhsaId { get; private set; }
#nullable restore
#else
        public string GhsaId { get; private set; }
#endif
        /// <summary>The URL for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; private set; }
#nullable restore
#else
        public string HtmlUrl { get; private set; }
#endif
        /// <summary>The identifiers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.RepositoryAdvisory_identifiers>? Identifiers { get; private set; }
#nullable restore
#else
        public List<global::GitHub.Models.RepositoryAdvisory_identifiers> Identifiers { get; private set; }
#endif
        /// <summary>A temporary private fork of the advisory&apos;s repository for collaborating on a fix.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleRepository? PrivateFork { get; private set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleRepository PrivateFork { get; private set; }
#endif
        /// <summary>The date and time of when the advisory was published, in ISO 8601 format.</summary>
        public DateTimeOffset? PublishedAt { get; private set; }
        /// <summary>The publisher of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.SimpleUser? Publisher { get; private set; }
#nullable restore
#else
        public global::GitHub.Models.SimpleUser Publisher { get; private set; }
#endif
        /// <summary>The severity of the advisory.</summary>
        public global::GitHub.Models.RepositoryAdvisory_severity? Severity { get; set; }
        /// <summary>The state of the advisory.</summary>
        public global::GitHub.Models.RepositoryAdvisory_state? State { get; set; }
        /// <summary>The submission property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.RepositoryAdvisory_submission? Submission { get; private set; }
#nullable restore
#else
        public global::GitHub.Models.RepositoryAdvisory_submission Submission { get; private set; }
#endif
        /// <summary>A short summary of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>The date and time of when the advisory was last updated, in ISO 8601 format.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The API URL for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>The vulnerabilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.RepositoryAdvisoryVulnerability>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.RepositoryAdvisoryVulnerability> Vulnerabilities { get; set; }
#endif
        /// <summary>The date and time of when the advisory was withdrawn, in ISO 8601 format.</summary>
        public DateTimeOffset? WithdrawnAt { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryAdvisory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RepositoryAdvisory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RepositoryAdvisory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                { "collaborating_teams", n => { CollaboratingTeams = n.GetCollectionOfObjectValues<global::GitHub.Models.Team>(global::GitHub.Models.Team.CreateFromDiscriminatorValue)?.AsList(); } },
                { "collaborating_users", n => { CollaboratingUsers = n.GetCollectionOfObjectValues<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "credits", n => { Credits = n.GetCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisory_credits>(global::GitHub.Models.RepositoryAdvisory_credits.CreateFromDiscriminatorValue)?.AsList(); } },
                { "credits_detailed", n => { CreditsDetailed = n.GetCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisoryCredit>(global::GitHub.Models.RepositoryAdvisoryCredit.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cve_id", n => { CveId = n.GetStringValue(); } },
                { "cvss", n => { Cvss = n.GetObjectValue<global::GitHub.Models.RepositoryAdvisory_cvss>(global::GitHub.Models.RepositoryAdvisory_cvss.CreateFromDiscriminatorValue); } },
                { "cwe_ids", n => { CweIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "cwes", n => { Cwes = n.GetCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisory_cwes>(global::GitHub.Models.RepositoryAdvisory_cwes.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "ghsa_id", n => { GhsaId = n.GetStringValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "identifiers", n => { Identifiers = n.GetCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisory_identifiers>(global::GitHub.Models.RepositoryAdvisory_identifiers.CreateFromDiscriminatorValue)?.AsList(); } },
                { "private_fork", n => { PrivateFork = n.GetObjectValue<global::GitHub.Models.SimpleRepository>(global::GitHub.Models.SimpleRepository.CreateFromDiscriminatorValue); } },
                { "published_at", n => { PublishedAt = n.GetDateTimeOffsetValue(); } },
                { "publisher", n => { Publisher = n.GetObjectValue<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue); } },
                { "severity", n => { Severity = n.GetEnumValue<global::GitHub.Models.RepositoryAdvisory_severity>(); } },
                { "state", n => { State = n.GetEnumValue<global::GitHub.Models.RepositoryAdvisory_state>(); } },
                { "submission", n => { Submission = n.GetObjectValue<global::GitHub.Models.RepositoryAdvisory_submission>(global::GitHub.Models.RepositoryAdvisory_submission.CreateFromDiscriminatorValue); } },
                { "summary", n => { Summary = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisoryVulnerability>(global::GitHub.Models.RepositoryAdvisoryVulnerability.CreateFromDiscriminatorValue)?.AsList(); } },
                { "withdrawn_at", n => { WithdrawnAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Team>("collaborating_teams", CollaboratingTeams);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.SimpleUser>("collaborating_users", CollaboratingUsers);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisory_credits>("credits", Credits);
            writer.WriteStringValue("cve_id", CveId);
            writer.WriteObjectValue<global::GitHub.Models.RepositoryAdvisory_cvss>("cvss", Cvss);
            writer.WriteCollectionOfPrimitiveValues<string>("cwe_ids", CweIds);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::GitHub.Models.RepositoryAdvisory_severity>("severity", Severity);
            writer.WriteEnumValue<global::GitHub.Models.RepositoryAdvisory_state>("state", State);
            writer.WriteStringValue("summary", Summary);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.RepositoryAdvisoryVulnerability>("vulnerabilities", Vulnerabilities);
        }
    }
}
#pragma warning restore CS0618
