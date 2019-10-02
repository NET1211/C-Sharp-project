// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Role is a namespaced, logical grouping of PolicyRules that can be
    /// referenced as a unit by a RoleBinding.
    /// </summary>
    public partial class V1beta1Role
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1Role class.
        /// </summary>
        public V1beta1Role()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1Role class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata.</param>
        /// <param name="rules">Rules holds all the PolicyRules for this
        /// Role</param>
        public V1beta1Role(string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), IList<V1beta1PolicyRule> rules = default(IList<V1beta1PolicyRule>))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets rules holds all the PolicyRules for this Role
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<V1beta1PolicyRule> Rules { get; set; }

    }
}
