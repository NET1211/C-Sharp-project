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
    /// ReplicationControllerCondition describes the state of a replication controller
        /// at a certain point.
    /// </summary>
    public partial class V1ReplicationControllerCondition
    {
        /// <summary>
        /// Initializes a new instance of the V1ReplicationControllerCondition class.
        /// </summary>
        public V1ReplicationControllerCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ReplicationControllerCondition class.
        /// </summary>
        /// <param name="status">
        /// Status of the condition, one of True, False, Unknown.
        /// </param>
        /// <param name="type">
        /// Type of replication controller condition.
        /// </param>
        /// <param name="lastTransitionTime">
        /// The last time the condition transitioned from one status to another.
        /// </param>
        /// <param name="message">
        /// A human readable message indicating details about the transition.
        /// </param>
        /// <param name="reason">
        /// The reason for the condition&apos;s last transition.
        /// </param>
        public V1ReplicationControllerCondition(string status, string type, System.DateTime? lastTransitionTime = null, string message = null, string reason = null)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The last time the condition transitioned from one status to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// A human readable message indicating details about the transition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The reason for the condition&apos;s last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of replication controller condition.
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
