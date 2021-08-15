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
    /// GroupVersion contains the &quot;group/version&quot; and &quot;version&quot; string of a version. It
        /// is made a struct to keep extensibility.
    /// </summary>
    public partial class V1GroupVersionForDiscovery
    {
        /// <summary>
        /// Initializes a new instance of the V1GroupVersionForDiscovery class.
        /// </summary>
        public V1GroupVersionForDiscovery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1GroupVersionForDiscovery class.
        /// </summary>
        /// <param name="groupVersion">
        /// groupVersion specifies the API group and version in the form &quot;group/version&quot;
        /// </param>
        /// <param name="version">
        /// version specifies the version in the form of &quot;version&quot;. This is to save the
        /// clients the trouble of splitting the GroupVersion.
        /// </param>
        public V1GroupVersionForDiscovery(string groupVersion, string version)
        {
            GroupVersion = groupVersion;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// groupVersion specifies the API group and version in the form &quot;group/version&quot;
        /// </summary>
        [JsonProperty(PropertyName = "groupVersion")]
        public string GroupVersion { get; set; }

        /// <summary>
        /// version specifies the version in the form of &quot;version&quot;. This is to save the
        /// clients the trouble of splitting the GroupVersion.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

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
