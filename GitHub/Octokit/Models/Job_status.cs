// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>The phase of the lifecycle that the job is currently in.</summary>
    public enum Job_status {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "in_progress")]
        In_progress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "waiting")]
        Waiting,
    }
}
