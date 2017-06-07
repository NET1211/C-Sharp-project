// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a volume that is populated with the contents of a git
    /// repository. Git repo volumes do not support ownership management. Git
    /// repo volumes support SELinux relabeling.
    /// </summary>
    public partial class V1GitRepoVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1GitRepoVolumeSource class.
        /// </summary>
        public V1GitRepoVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1GitRepoVolumeSource class.
        /// </summary>
        /// <param name="repository">Repository URL</param>
        /// <param name="directory">Target directory name. Must not contain or
        /// start with '..'.  If '.' is supplied, the volume directory will be
        /// the git repository.  Otherwise, if specified, the volume will
        /// contain the git repository in the subdirectory with the given
        /// name.</param>
        /// <param name="revision">Commit hash for the specified
        /// revision.</param>
        public V1GitRepoVolumeSource(string repository, string directory = default(string), string revision = default(string))
        {
            Directory = directory;
            Repository = repository;
            Revision = revision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target directory name. Must not contain or start with
        /// '..'.  If '.' is supplied, the volume directory will be the git
        /// repository.  Otherwise, if specified, the volume will contain the
        /// git repository in the subdirectory with the given name.
        /// </summary>
        [JsonProperty(PropertyName = "directory")]
        public string Directory { get; set; }

        /// <summary>
        /// Gets or sets repository URL
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// Gets or sets commit hash for the specified revision.
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public string Revision { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Repository == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Repository");
            }
        }
    }
}
