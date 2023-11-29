// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>The type of repositories in the organization that the secret is visible to</summary>
    public enum CodespacesSecret_visibility {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "selected")]
        Selected,
    }
}