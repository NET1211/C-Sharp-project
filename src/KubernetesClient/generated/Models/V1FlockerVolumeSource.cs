// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// Represents a Flocker volume mounted by the Flocker agent. One and only one of
        /// datasetName and datasetUUID should be set. Flocker volumes do not support
        /// ownership management or SELinux relabeling.
    /// </summary>
    public partial class V1FlockerVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1FlockerVolumeSource class.
        /// </summary>
        public V1FlockerVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1FlockerVolumeSource class.
        /// </summary>
        /// <param name="datasetName">
        /// Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should
        /// be considered as deprecated
        /// </param>
        /// <param name="datasetUUID">
        /// UUID of the dataset. This is unique identifier of a Flocker dataset
        /// </param>
        public V1FlockerVolumeSource(string datasetName = null, string datasetUUID = null)
        {
            DatasetName = datasetName;
            DatasetUUID = datasetUUID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should
        /// be considered as deprecated
        /// </summary>
        [JsonPropertyName("datasetName")]
        public string DatasetName { get; set; }

        /// <summary>
        /// UUID of the dataset. This is unique identifier of a Flocker dataset
        /// </summary>
        [JsonPropertyName("datasetUUID")]
        public string DatasetUUID { get; set; }

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
