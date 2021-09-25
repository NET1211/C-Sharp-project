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
    /// IngressSpec describes the Ingress the user wishes to exist.
    /// </summary>
    public partial class V1IngressSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1IngressSpec class.
        /// </summary>
        public V1IngressSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1IngressSpec class.
        /// </summary>
        /// <param name="defaultBackend">
        /// DefaultBackend is the backend that should handle requests that don&apos;t match any
        /// rule. If Rules are not specified, DefaultBackend must be specified. If
        /// DefaultBackend is not set, the handling of requests that do not match any of the
        /// rules will be up to the Ingress controller.
        /// </param>
        /// <param name="ingressClassName">
        /// IngressClassName is the name of the IngressClass cluster resource. The
        /// associated IngressClass defines which controller will implement the resource.
        /// This replaces the deprecated `kubernetes.io/ingress.class` annotation. For
        /// backwards compatibility, when that annotation is set, it must be given
        /// precedence over this field. The controller may emit a warning if the field and
        /// annotation have different values. Implementations of this API should ignore
        /// Ingresses without a class specified. An IngressClass resource may be marked as
        /// default, which can be used to set a default value for this field. For more
        /// information, refer to the IngressClass documentation.
        /// </param>
        /// <param name="rules">
        /// A list of host rules used to configure the Ingress. If unspecified, or no rule
        /// matches, all traffic is sent to the default backend.
        /// </param>
        /// <param name="tls">
        /// TLS configuration. Currently the Ingress only supports a single TLS port, 443.
        /// If multiple members of this list specify different hosts, they will be
        /// multiplexed on the same port according to the hostname specified through the SNI
        /// TLS extension, if the ingress controller fulfilling the ingress supports SNI.
        /// </param>
        public V1IngressSpec(V1IngressBackend defaultBackend = null, string ingressClassName = null, IList<V1IngressRule> rules = null, IList<V1IngressTLS> tls = null)
        {
            DefaultBackend = defaultBackend;
            IngressClassName = ingressClassName;
            Rules = rules;
            Tls = tls;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// DefaultBackend is the backend that should handle requests that don&apos;t match any
        /// rule. If Rules are not specified, DefaultBackend must be specified. If
        /// DefaultBackend is not set, the handling of requests that do not match any of the
        /// rules will be up to the Ingress controller.
        /// </summary>
        [JsonProperty(PropertyName = "defaultBackend")]
        public V1IngressBackend DefaultBackend { get; set; }

        /// <summary>
        /// IngressClassName is the name of the IngressClass cluster resource. The
        /// associated IngressClass defines which controller will implement the resource.
        /// This replaces the deprecated `kubernetes.io/ingress.class` annotation. For
        /// backwards compatibility, when that annotation is set, it must be given
        /// precedence over this field. The controller may emit a warning if the field and
        /// annotation have different values. Implementations of this API should ignore
        /// Ingresses without a class specified. An IngressClass resource may be marked as
        /// default, which can be used to set a default value for this field. For more
        /// information, refer to the IngressClass documentation.
        /// </summary>
        [JsonProperty(PropertyName = "ingressClassName")]
        public string IngressClassName { get; set; }

        /// <summary>
        /// A list of host rules used to configure the Ingress. If unspecified, or no rule
        /// matches, all traffic is sent to the default backend.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<V1IngressRule> Rules { get; set; }

        /// <summary>
        /// TLS configuration. Currently the Ingress only supports a single TLS port, 443.
        /// If multiple members of this list specify different hosts, they will be
        /// multiplexed on the same port according to the hostname specified through the SNI
        /// TLS extension, if the ingress controller fulfilling the ingress supports SNI.
        /// </summary>
        [JsonProperty(PropertyName = "tls")]
        public IList<V1IngressTLS> Tls { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            DefaultBackend?.Validate();
            if (Rules != null){
                foreach(var obj in Rules)
                {
                    obj.Validate();
                }
            }
            if (Tls != null){
                foreach(var obj in Tls)
                {
                    obj.Validate();
                }
            }
        }
    }
}
