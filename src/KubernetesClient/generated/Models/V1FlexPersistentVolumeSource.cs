// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// FlexPersistentVolumeSource represents a generic persistent volume resource that
        /// is provisioned/attached using an exec based plugin.
    /// </summary>
    public partial class V1FlexPersistentVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1FlexPersistentVolumeSource class.
        /// </summary>
        public V1FlexPersistentVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1FlexPersistentVolumeSource class.
        /// </summary>
        /// <param name="driver">
        /// Driver is the name of the driver to use for this volume.
        /// </param>
        /// <param name="fsType">
        /// Filesystem type to mount. Must be a filesystem type supported by the host
        /// operating system. Ex. &quot;ext4&quot;, &quot;xfs&quot;, &quot;ntfs&quot;. The default filesystem depends on
        /// FlexVolume script.
        /// </param>
        /// <param name="options">
        /// Optional: Extra command options if any.
        /// </param>
        /// <param name="readOnlyProperty">
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly
        /// setting in VolumeMounts.
        /// </param>
        /// <param name="secretRef">
        /// Optional: SecretRef is reference to the secret object containing sensitive
        /// information to pass to the plugin scripts. This may be empty if no secret object
        /// is specified. If the secret object contains more than one secret, all secrets
        /// are passed to the plugin scripts.
        /// </param>
        public V1FlexPersistentVolumeSource(string driver, string fsType = null, IDictionary<string, string> options = null, bool? readOnlyProperty = null, V1SecretReference secretRef = null)
        {
            Driver = driver;
            FsType = fsType;
            Options = options;
            ReadOnlyProperty = readOnlyProperty;
            SecretRef = secretRef;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Driver is the name of the driver to use for this volume.
        /// </summary>
        [JsonProperty(PropertyName = "driver")]
        public string Driver { get; set; }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host
        /// operating system. Ex. &quot;ext4&quot;, &quot;xfs&quot;, &quot;ntfs&quot;. The default filesystem depends on
        /// FlexVolume script.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Optional: Extra command options if any.
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IDictionary<string, string> Options { get; set; }

        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly
        /// setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Optional: SecretRef is reference to the secret object containing sensitive
        /// information to pass to the plugin scripts. This may be empty if no secret object
        /// is specified. If the secret object contains more than one secret, all secrets
        /// are passed to the plugin scripts.
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public V1SecretReference SecretRef { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            SecretRef?.Validate();
        }
    }
}
