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
    /// RoleList is a collection of Roles. Deprecated in v1.17 in favor of
        /// rbac.authorization.k8s.io/v1 RoleList, and will no longer be served in v1.22.
    /// </summary>
    public partial class V1alpha1RoleList
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1RoleList class.
        /// </summary>
        public V1alpha1RoleList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1RoleList class.
        /// </summary>
        /// <param name="items">
        /// Items is a list of Roles
        /// </param>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object&apos;s metadata.
        /// </param>
        public V1alpha1RoleList(IList<V1alpha1Role> items, string apiVersion = null, string kind = null, V1ListMeta metadata = null)
        {
            ApiVersion = apiVersion;
            Items = items;
            Kind = kind;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Items is a list of Roles
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<V1alpha1Role> Items { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&apos;s metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ListMeta Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Items != null){
                foreach(var obj in Items)
                {
                    obj.Validate();
                }
            }
            Metadata?.Validate();
        }
    }
}
