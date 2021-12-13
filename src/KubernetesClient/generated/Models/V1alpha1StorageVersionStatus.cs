// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// API server instances report the versions they can decode and the version they
        /// encode objects to when persisting objects in the backend.
    /// </summary>
    public partial class V1alpha1StorageVersionStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1StorageVersionStatus class.
        /// </summary>
        public V1alpha1StorageVersionStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1StorageVersionStatus class.
        /// </summary>
        /// <param name="commonEncodingVersion">
        /// If all API server instances agree on the same encoding storage version, then
        /// this field is set to that version. Otherwise this field is left empty. API
        /// servers should finish updating its storageVersionStatus entry before serving
        /// write operations, so that this field will be in sync with the reality.
        /// </param>
        /// <param name="conditions">
        /// The latest available observations of the storageVersion&apos;s state.
        /// </param>
        /// <param name="storageVersions">
        /// The reported versions per API server instance.
        /// </param>
        public V1alpha1StorageVersionStatus(string commonEncodingVersion = null, IList<V1alpha1StorageVersionCondition> conditions = null, IList<V1alpha1ServerStorageVersion> storageVersions = null)
        {
            CommonEncodingVersion = commonEncodingVersion;
            Conditions = conditions;
            StorageVersions = storageVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// If all API server instances agree on the same encoding storage version, then
        /// this field is set to that version. Otherwise this field is left empty. API
        /// servers should finish updating its storageVersionStatus entry before serving
        /// write operations, so that this field will be in sync with the reality.
        /// </summary>
        [JsonPropertyName("commonEncodingVersion")]
        public string CommonEncodingVersion { get; set; }

        /// <summary>
        /// The latest available observations of the storageVersion&apos;s state.
        /// </summary>
        [JsonPropertyName("conditions")]
        public IList<V1alpha1StorageVersionCondition> Conditions { get; set; }

        /// <summary>
        /// The reported versions per API server instance.
        /// </summary>
        [JsonPropertyName("storageVersions")]
        public IList<V1alpha1ServerStorageVersion> StorageVersions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null){
                foreach(var obj in Conditions)
                {
                    obj.Validate();
                }
            }
            if (StorageVersions != null){
                foreach(var obj in StorageVersions)
                {
                    obj.Validate();
                }
            }
        }
    }
}
