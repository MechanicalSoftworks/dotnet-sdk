// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    #pragma warning disable CS1591
    public class CodeScanningVariantAnalysisRepoTask : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The new status of the CodeQL variant analysis repository task.</summary>
        public CodeScanningVariantAnalysisStatus? AnalysisStatus { get; set; }
        /// <summary>The size of the artifact. This is only available for successful analyses.</summary>
        public int? ArtifactSizeInBytes { get; set; }
        /// <summary>The URL of the artifact. This is only available for successful analyses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArtifactUrl { get; set; }
#nullable restore
#else
        public string ArtifactUrl { get; set; }
#endif
        /// <summary>The SHA of the commit the CodeQL database was built against. This is only available for successful analyses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatabaseCommitSha { get; set; }
#nullable restore
#else
        public string DatabaseCommitSha { get; set; }
#endif
        /// <summary>The reason of the failure of this repo task. This is only available if the repository task has failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailureMessage { get; set; }
#nullable restore
#else
        public string FailureMessage { get; set; }
#endif
        /// <summary>A GitHub repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleRepository? Repository { get; set; }
#nullable restore
#else
        public SimpleRepository Repository { get; set; }
#endif
        /// <summary>The number of results in the case of a successful analysis. This is only available for successful analyses.</summary>
        public int? ResultCount { get; set; }
        /// <summary>The source location prefix to use. This is only available for successful analyses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceLocationPrefix { get; set; }
#nullable restore
#else
        public string SourceLocationPrefix { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CodeScanningVariantAnalysisRepoTask"/> and sets the default values.
        /// </summary>
        public CodeScanningVariantAnalysisRepoTask()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CodeScanningVariantAnalysisRepoTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeScanningVariantAnalysisRepoTask CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeScanningVariantAnalysisRepoTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "analysis_status", n => { AnalysisStatus = n.GetEnumValue<CodeScanningVariantAnalysisStatus>(); } },
                { "artifact_size_in_bytes", n => { ArtifactSizeInBytes = n.GetIntValue(); } },
                { "artifact_url", n => { ArtifactUrl = n.GetStringValue(); } },
                { "database_commit_sha", n => { DatabaseCommitSha = n.GetStringValue(); } },
                { "failure_message", n => { FailureMessage = n.GetStringValue(); } },
                { "repository", n => { Repository = n.GetObjectValue<SimpleRepository>(SimpleRepository.CreateFromDiscriminatorValue); } },
                { "result_count", n => { ResultCount = n.GetIntValue(); } },
                { "source_location_prefix", n => { SourceLocationPrefix = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CodeScanningVariantAnalysisStatus>("analysis_status", AnalysisStatus);
            writer.WriteIntValue("artifact_size_in_bytes", ArtifactSizeInBytes);
            writer.WriteStringValue("artifact_url", ArtifactUrl);
            writer.WriteStringValue("database_commit_sha", DatabaseCommitSha);
            writer.WriteStringValue("failure_message", FailureMessage);
            writer.WriteObjectValue<SimpleRepository>("repository", Repository);
            writer.WriteIntValue("result_count", ResultCount);
            writer.WriteStringValue("source_location_prefix", SourceLocationPrefix);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
