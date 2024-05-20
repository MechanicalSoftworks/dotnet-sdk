// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Git.Tags
{
    /// <summary>The type of the object we&apos;re tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.</summary>
    public enum TagsPostRequestBody_type
    {
        [EnumMember(Value = "commit")]
        #pragma warning disable CS1591
        Commit,
        #pragma warning restore CS1591
        [EnumMember(Value = "tree")]
        #pragma warning disable CS1591
        Tree,
        #pragma warning restore CS1591
        [EnumMember(Value = "blob")]
        #pragma warning disable CS1591
        Blob,
        #pragma warning restore CS1591
    }
}
