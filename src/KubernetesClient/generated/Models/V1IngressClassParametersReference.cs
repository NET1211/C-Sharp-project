// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// IngressClassParametersReference identifies an API object. This can be used to
        /// specify a cluster or namespace-scoped resource.
    /// </summary>
    public partial class V1IngressClassParametersReference
    {
        /// <summary>
        /// Initializes a new instance of the V1IngressClassParametersReference class.
        /// </summary>
        public V1IngressClassParametersReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1IngressClassParametersReference class.
        /// </summary>
        /// <param name="kind">
        /// Kind is the type of resource being referenced.
        /// </param>
        /// <param name="name">
        /// Name is the name of resource being referenced.
        /// </param>
        /// <param name="apiGroup">
        /// APIGroup is the group for the resource being referenced. If APIGroup is not
        /// specified, the specified Kind must be in the core API group. For any other
        /// third-party types, APIGroup is required.
        /// </param>
        /// <param name="namespaceProperty">
        /// Namespace is the namespace of the resource being referenced. This field is
        /// required when scope is set to &quot;Namespace&quot; and must be unset when scope is set to
        /// &quot;Cluster&quot;.
        /// </param>
        /// <param name="scope">
        /// Scope represents if this refers to a cluster or namespace scoped resource. This
        /// may be set to &quot;Cluster&quot; (default) or &quot;Namespace&quot;.
        /// </param>
        public V1IngressClassParametersReference(string kind, string name, string apiGroup = null, string namespaceProperty = null, string scope = null)
        {
            ApiGroup = apiGroup;
            Kind = kind;
            Name = name;
            NamespaceProperty = namespaceProperty;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIGroup is the group for the resource being referenced. If APIGroup is not
        /// specified, the specified Kind must be in the core API group. For any other
        /// third-party types, APIGroup is required.
        /// </summary>
        [JsonPropertyName("apiGroup")]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Kind is the type of resource being referenced.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Name is the name of resource being referenced.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Namespace is the namespace of the resource being referenced. This field is
        /// required when scope is set to &quot;Namespace&quot; and must be unset when scope is set to
        /// &quot;Cluster&quot;.
        /// </summary>
        [JsonPropertyName("namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Scope represents if this refers to a cluster or namespace scoped resource. This
        /// may be set to &quot;Cluster&quot; (default) or &quot;Namespace&quot;.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

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
