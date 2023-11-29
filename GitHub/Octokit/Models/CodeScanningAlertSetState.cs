// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.</summary>
    public enum CodeScanningAlertSetState {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "dismissed")]
        Dismissed,
    }
}
