// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// AllowedHostPath defines the host volume conditions that will be enabled by a
        /// policy for pods to use. It requires the path prefix to be defined.
    /// </summary>
    public partial class V1beta1AllowedHostPath
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1AllowedHostPath class.
        /// </summary>
        public V1beta1AllowedHostPath()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1AllowedHostPath class.
        /// </summary>
        /// <param name="pathPrefix">
        /// pathPrefix is the path prefix that the host volume must match. It does not
        /// support `*`. Trailing slashes are trimmed when validating the path prefix with a
        /// host path.
        /// 
        /// Examples: `/foo` would allow `/foo`, `/foo/` and `/foo/bar` `/foo` would not
        /// allow `/food` or `/etc/foo`
        /// </param>
        /// <param name="readOnlyProperty">
        /// when set to true, will allow host volumes matching the pathPrefix only if all
        /// volume mounts are readOnly.
        /// </param>
        public V1beta1AllowedHostPath(string pathPrefix = null, bool? readOnlyProperty = null)
        {
            PathPrefix = pathPrefix;
            ReadOnlyProperty = readOnlyProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// pathPrefix is the path prefix that the host volume must match. It does not
        /// support `*`. Trailing slashes are trimmed when validating the path prefix with a
        /// host path.
        /// 
        /// Examples: `/foo` would allow `/foo`, `/foo/` and `/foo/bar` `/foo` would not
        /// allow `/food` or `/etc/foo`
        /// </summary>
        [JsonPropertyName("pathPrefix")]
        public string PathPrefix { get; set; }

        /// <summary>
        /// when set to true, will allow host volumes matching the pathPrefix only if all
        /// volume mounts are readOnly.
        /// </summary>
        [JsonPropertyName("readOnly")]
        public bool? ReadOnlyProperty { get; set; }

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
