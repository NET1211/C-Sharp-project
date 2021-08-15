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
    /// SeccompProfile defines a pod/container&apos;s seccomp profile settings. Only one
        /// profile source may be set.
    /// </summary>
    public partial class V1SeccompProfile
    {
        /// <summary>
        /// Initializes a new instance of the V1SeccompProfile class.
        /// </summary>
        public V1SeccompProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SeccompProfile class.
        /// </summary>
        /// <param name="type">
        /// type indicates which kind of seccomp profile will be applied. Valid options are:
        /// 
        /// Localhost - a profile defined in a file on the node should be used.
        /// RuntimeDefault - the container runtime default profile should be used.
        /// Unconfined - no profile should be applied.
        /// </param>
        /// <param name="localhostProfile">
        /// localhostProfile indicates a profile defined in a file on the node should be
        /// used. The profile must be preconfigured on the node to work. Must be a
        /// descending path, relative to the kubelet&apos;s configured seccomp profile location.
        /// Must only be set if type is &quot;Localhost&quot;.
        /// </param>
        public V1SeccompProfile(string type, string localhostProfile = null)
        {
            LocalhostProfile = localhostProfile;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// localhostProfile indicates a profile defined in a file on the node should be
        /// used. The profile must be preconfigured on the node to work. Must be a
        /// descending path, relative to the kubelet&apos;s configured seccomp profile location.
        /// Must only be set if type is &quot;Localhost&quot;.
        /// </summary>
        [JsonProperty(PropertyName = "localhostProfile")]
        public string LocalhostProfile { get; set; }

        /// <summary>
        /// type indicates which kind of seccomp profile will be applied. Valid options are:
        /// 
        /// Localhost - a profile defined in a file on the node should be used.
        /// RuntimeDefault - the container runtime default profile should be used.
        /// Unconfined - no profile should be applied.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

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
