// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs
        /// volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    public partial class V1CephFSPersistentVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1CephFSPersistentVolumeSource class.
        /// </summary>
        public V1CephFSPersistentVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CephFSPersistentVolumeSource class.
        /// </summary>
        /// <param name="monitors">
        /// Required: Monitors is a collection of Ceph monitors More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </param>
        /// <param name="path">
        /// Optional: Used as the mounted root, rather than the full Ceph tree, default is /
        /// </param>
        /// <param name="readOnlyProperty">
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly
        /// setting in VolumeMounts. More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </param>
        /// <param name="secretFile">
        /// Optional: SecretFile is the path to key ring for User, default is
        /// /etc/ceph/user.secret More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </param>
        /// <param name="secretRef">
        /// Optional: SecretRef is reference to the authentication secret for User, default
        /// is empty. More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </param>
        /// <param name="user">
        /// Optional: User is the rados user name, default is admin More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </param>
        public V1CephFSPersistentVolumeSource(IList<string> monitors, string path = null, bool? readOnlyProperty = null, string secretFile = null, V1SecretReference secretRef = null, string user = null)
        {
            Monitors = monitors;
            Path = path;
            ReadOnlyProperty = readOnlyProperty;
            SecretFile = secretFile;
            SecretRef = secretRef;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Required: Monitors is a collection of Ceph monitors More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonPropertyName("monitors")]
        public IList<string> Monitors { get; set; }

        /// <summary>
        /// Optional: Used as the mounted root, rather than the full Ceph tree, default is /
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly
        /// setting in VolumeMounts. More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonPropertyName("readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Optional: SecretFile is the path to key ring for User, default is
        /// /etc/ceph/user.secret More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonPropertyName("secretFile")]
        public string SecretFile { get; set; }

        /// <summary>
        /// Optional: SecretRef is reference to the authentication secret for User, default
        /// is empty. More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonPropertyName("secretRef")]
        public V1SecretReference SecretRef { get; set; }

        /// <summary>
        /// Optional: User is the rados user name, default is admin More info:
        /// https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; }

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
