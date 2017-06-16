// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Status is a return value for calls that don't return other objects.
    /// </summary>
    public partial class V1Status
    {
        /// <summary>
        /// Initializes a new instance of the V1Status class.
        /// </summary>
        public V1Status()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Status class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</param>
        /// <param name="code">Suggested HTTP return code for this status, 0 if
        /// not set.</param>
        /// <param name="details">Extended data associated with the reason.
        /// Each reason may define its own extended details. This field is
        /// optional and the data returned is not guaranteed to conform to any
        /// schema except that defined by the reason type.</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</param>
        /// <param name="message">A human-readable description of the status of
        /// this operation.</param>
        /// <param name="metadata">Standard list metadata. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</param>
        /// <param name="reason">A machine-readable description of why this
        /// operation is in the "Failure" status. If this value is empty there
        /// is no information available. A Reason clarifies an HTTP status code
        /// but does not override it.</param>
        /// <param name="status">Status of the operation. One of: "Success" or
        /// "Failure". More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#spec-and-status</param>
        public V1Status(string apiVersion = default(string), int? code = default(int?), V1StatusDetails details = default(V1StatusDetails), string kind = default(string), string message = default(string), V1ListMeta metadata = default(V1ListMeta), string reason = default(string), string status = default(string))
        {
            ApiVersion = apiVersion;
            Code = code;
            Details = details;
            Kind = kind;
            Message = message;
            Metadata = metadata;
            Reason = reason;
            Status = status;
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
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets suggested HTTP return code for this status, 0 if not
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets extended data associated with the reason.  Each reason
        /// may define its own extended details. This field is optional and the
        /// data returned is not guaranteed to conform to any schema except
        /// that defined by the reason type.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public V1StatusDetails Details { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets a human-readable description of the status of this
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets standard list metadata. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ListMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets a machine-readable description of why this operation
        /// is in the "Failure" status. If this value is empty there is no
        /// information available. A Reason clarifies an HTTP status code but
        /// does not override it.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets status of the operation. One of: "Success" or
        /// "Failure". More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
