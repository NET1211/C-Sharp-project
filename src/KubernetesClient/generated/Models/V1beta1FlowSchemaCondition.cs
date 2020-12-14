// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// FlowSchemaCondition describes conditions for a FlowSchema.
    /// </summary>
    public partial class V1beta1FlowSchemaCondition
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1FlowSchemaCondition class.
        /// </summary>
        public V1beta1FlowSchemaCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1FlowSchemaCondition class.
        /// </summary>
        /// <param name="lastTransitionTime">`lastTransitionTime` is the last
        /// time the condition transitioned from one status to another.</param>
        /// <param name="message">`message` is a human-readable message
        /// indicating details about last transition.</param>
        /// <param name="reason">`reason` is a unique, one-word, CamelCase
        /// reason for the condition's last transition.</param>
        /// <param name="status">`status` is the status of the condition. Can
        /// be True, False, Unknown. Required.</param>
        /// <param name="type">`type` is the type of the condition.
        /// Required.</param>
        public V1beta1FlowSchemaCondition(System.DateTime? lastTransitionTime = default(System.DateTime?), string message = default(string), string reason = default(string), string status = default(string), string type = default(string))
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
        /// Gets or sets `lastTransitionTime` is the last time the condition
        /// transitioned from one status to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets `message` is a human-readable message indicating
        /// details about last transition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets `reason` is a unique, one-word, CamelCase reason for
        /// the condition's last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets `status` is the status of the condition. Can be True,
        /// False, Unknown. Required.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets `type` is the type of the condition. Required.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
