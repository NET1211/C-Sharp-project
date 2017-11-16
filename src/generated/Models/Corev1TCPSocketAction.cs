// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TCPSocketAction describes an action based on opening a socket
    /// </summary>
    public partial class Corev1TCPSocketAction
    {
        /// <summary>
        /// Initializes a new instance of the Corev1TCPSocketAction class.
        /// </summary>
        public Corev1TCPSocketAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1TCPSocketAction class.
        /// </summary>
        /// <param name="port">Number or name of the port to access on the
        /// container. Number must be in the range 1 to 65535. Name must be an
        /// IANA_SVC_NAME.</param>
        /// <param name="host">Optional: Host name to connect to, defaults to
        /// the pod IP.</param>
        public Corev1TCPSocketAction(IntOrString port, string host = default(string))
        {
            Host = host;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional: Host name to connect to, defaults to the pod
        /// IP.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets number or name of the port to access on the container.
        /// Number must be in the range 1 to 65535. Name must be an
        /// IANA_SVC_NAME.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public IntOrString Port { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Port == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Port");
            }
        }
    }
}
