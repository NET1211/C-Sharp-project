// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Persistent Disk resource in Google Compute Engine.
    ///
    /// A GCE PD must exist before mounting to a container. The disk must also
    /// be in the same GCE project and zone as the kubelet. A GCE PD can only
    /// be mounted as read/write once or read-only many times. GCE PDs support
    /// ownership management and SELinux relabeling.
    /// </summary>
    public partial class V1GCEPersistentDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1GCEPersistentDiskVolumeSource
        /// class.
        /// </summary>
        public V1GCEPersistentDiskVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1GCEPersistentDiskVolumeSource
        /// class.
        /// </summary>
        /// <param name="pdName">Unique name of the PD resource in GCE. Used to
        /// identify the disk in GCE. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk</param>
        /// <param name="fsType">Filesystem type of the volume that you want to
        /// mount. Tip: Ensure that the filesystem type is supported by the
        /// host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk</param>
        /// <param name="partition">The partition in the volume that you want
        /// to mount. If omitted, the default is to mount by volume name.
        /// Examples: For volume /dev/sda1, you specify the partition as "1".
        /// Similarly, the volume partition for /dev/sda is "0" (or you can
        /// leave the property empty). More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk</param>
        /// <param name="readOnlyProperty">ReadOnly here will force the
        /// ReadOnly setting in VolumeMounts. Defaults to false. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk</param>
        public V1GCEPersistentDiskVolumeSource(string pdName, string fsType = default(string), int? partition = default(int?), bool? readOnlyProperty = default(bool?))
        {
            FsType = fsType;
            Partition = partition;
            PdName = pdName;
            ReadOnlyProperty = readOnlyProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type of the volume that you want to mount.
        /// Tip: Ensure that the filesystem type is supported by the host
        /// operating system. Examples: "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets the partition in the volume that you want to mount. If
        /// omitted, the default is to mount by volume name. Examples: For
        /// volume /dev/sda1, you specify the partition as "1". Similarly, the
        /// volume partition for /dev/sda is "0" (or you can leave the property
        /// empty). More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "partition")]
        public int? Partition { get; set; }

        /// <summary>
        /// Gets or sets unique name of the PD resource in GCE. Used to
        /// identify the disk in GCE. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "pdName")]
        public string PdName { get; set; }

        /// <summary>
        /// Gets or sets readOnly here will force the ReadOnly setting in
        /// VolumeMounts. Defaults to false. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PdName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PdName");
            }
        }
    }
}
