// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Represents a Photon Controller persistent disk resource.
    /// </summary>
    public partial class V1PhotonPersistentDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1PhotonPersistentDiskVolumeSource class.
        /// </summary>
        public V1PhotonPersistentDiskVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PhotonPersistentDiskVolumeSource class.
        /// </summary>
        /// <param name="pdID">
        /// ID that identifies Photon Controller persistent disk
        /// </param>
        /// <param name="fsType">
        /// Filesystem type to mount. Must be a filesystem type supported by the host
        /// operating system. Ex. &quot;ext4&quot;, &quot;xfs&quot;, &quot;ntfs&quot;. Implicitly inferred to be &quot;ext4&quot; if
        /// unspecified.
        /// </param>
        public V1PhotonPersistentDiskVolumeSource(string pdID, string fsType = null)
        {
            FsType = fsType;
            PdID = pdID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host
        /// operating system. Ex. &quot;ext4&quot;, &quot;xfs&quot;, &quot;ntfs&quot;. Implicitly inferred to be &quot;ext4&quot; if
        /// unspecified.
        /// </summary>
        [JsonPropertyName("fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// ID that identifies Photon Controller persistent disk
        /// </summary>
        [JsonPropertyName("pdID")]
        public string PdID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
