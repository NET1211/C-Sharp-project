// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ServiceReference holds a reference to Service.legacy.k8s.io
    /// </summary>
    public partial class Apiextensionsv1ServiceReference
    {
        /// <summary>
        /// Initializes a new instance of the Apiextensionsv1ServiceReference class.
        /// </summary>
        public Apiextensionsv1ServiceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Apiextensionsv1ServiceReference class.
        /// </summary>
        /// <param name="name">
        /// name is the name of the service. Required
        /// </param>
        /// <param name="namespaceProperty">
        /// namespace is the namespace of the service. Required
        /// </param>
        /// <param name="path">
        /// path is an optional URL path at which the webhook will be contacted.
        /// </param>
        /// <param name="port">
        /// port is an optional service port at which the webhook will be contacted. `port`
        /// should be a valid port number (1-65535, inclusive). Defaults to 443 for backward
        /// compatibility.
        /// </param>
        public Apiextensionsv1ServiceReference(string name, string namespaceProperty, string path = null, int? port = null)
        {
            Name = name;
            NamespaceProperty = namespaceProperty;
            Path = path;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// name is the name of the service. Required
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// namespace is the namespace of the service. Required
        /// </summary>
        [JsonPropertyName("namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// path is an optional URL path at which the webhook will be contacted.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// port is an optional service port at which the webhook will be contacted. `port`
        /// should be a valid port number (1-65535, inclusive). Defaults to 443 for backward
        /// compatibility.
        /// </summary>
        [JsonPropertyName("port")]
        public int? Port { get; set; }

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
