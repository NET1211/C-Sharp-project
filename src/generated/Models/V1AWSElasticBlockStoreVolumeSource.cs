// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Persistent Disk resource in AWS.
    ///
    /// An AWS EBS disk must exist before mounting to a container. The disk
    /// must also be in the same AWS zone as the kubelet. An AWS EBS disk can
    /// only be mounted as read/write once. AWS EBS volumes support ownership
    /// management and SELinux relabeling.
    /// </summary>
    public partial class V1AWSElasticBlockStoreVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1AWSElasticBlockStoreVolumeSource class.
        /// </summary>
        public V1AWSElasticBlockStoreVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1AWSElasticBlockStoreVolumeSource class.
        /// </summary>
        /// <param name="volumeID">Unique ID of the persistent disk resource in
        /// AWS (Amazon EBS volume). More info:
        /// http://kubernetes.io/docs/user-guide/volumes#awselasticblockstore</param>
        /// <param name="fsType">Filesystem type of the volume that you want to
        /// mount. Tip: Ensure that the filesystem type is supported by the
        /// host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#awselasticblockstore</param>
        /// <param name="partition">The partition in the volume that you want
        /// to mount. If omitted, the default is to mount by volume name.
        /// Examples: For volume /dev/sda1, you specify the partition as "1".
        /// Similarly, the volume partition for /dev/sda is "0" (or you can
        /// leave the property empty).</param>
        /// <param name="readOnlyProperty">Specify "true" to force and set the
        /// ReadOnly property in VolumeMounts to "true". If omitted, the
        /// default is "false". More info:
        /// http://kubernetes.io/docs/user-guide/volumes#awselasticblockstore</param>
        public V1AWSElasticBlockStoreVolumeSource(string volumeID, string fsType = default(string), int? partition = default(int?), bool? readOnlyProperty = default(bool?))
        {
            FsType = fsType;
            Partition = partition;
            ReadOnlyProperty = readOnlyProperty;
            VolumeID = volumeID;
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
        /// http://kubernetes.io/docs/user-guide/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets the partition in the volume that you want to mount. If
        /// omitted, the default is to mount by volume name. Examples: For
        /// volume /dev/sda1, you specify the partition as "1". Similarly, the
        /// volume partition for /dev/sda is "0" (or you can leave the property
        /// empty).
        /// </summary>
        [JsonProperty(PropertyName = "partition")]
        public int? Partition { get; set; }

        /// <summary>
        /// Gets or sets specify "true" to force and set the ReadOnly property
        /// in VolumeMounts to "true". If omitted, the default is "false". More
        /// info:
        /// http://kubernetes.io/docs/user-guide/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets unique ID of the persistent disk resource in AWS
        /// (Amazon EBS volume). More info:
        /// http://kubernetes.io/docs/user-guide/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "volumeID")]
        public string VolumeID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VolumeID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VolumeID");
            }
        }
    }
}
