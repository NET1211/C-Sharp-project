// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a vSphere volume resource.
    /// </summary>
    public partial class V1VsphereVirtualDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1VsphereVirtualDiskVolumeSource
        /// class.
        /// </summary>
        public V1VsphereVirtualDiskVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1VsphereVirtualDiskVolumeSource
        /// class.
        /// </summary>
        /// <param name="volumePath">Path that identifies vSphere volume
        /// vmdk</param>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Ex. "ext4", "xfs",
        /// "ntfs". Implicitly inferred to be "ext4" if unspecified.</param>
        public V1VsphereVirtualDiskVolumeSource(string volumePath, string fsType = default(string))
        {
            FsType = fsType;
            VolumePath = volumePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        /// Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets path that identifies vSphere volume vmdk
        /// </summary>
        [JsonProperty(PropertyName = "volumePath")]
        public string VolumePath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VolumePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VolumePath");
            }
        }
    }
}
