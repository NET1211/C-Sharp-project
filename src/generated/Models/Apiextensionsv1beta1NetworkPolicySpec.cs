// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Apiextensionsv1beta1NetworkPolicySpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Apiextensionsv1beta1NetworkPolicySpec class.
        /// </summary>
        public Apiextensionsv1beta1NetworkPolicySpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Apiextensionsv1beta1NetworkPolicySpec class.
        /// </summary>
        /// <param name="podSelector">Selects the pods to which this
        /// NetworkPolicy object applies.  The array of ingress rules is
        /// applied to any pods selected by this field. Multiple network
        /// policies can select the same set of pods.  In this case, the
        /// ingress rules for each are combined additively. This field is NOT
        /// optional and follows standard label selector semantics. An empty
        /// podSelector matches all pods in this namespace.</param>
        /// <param name="egress">List of egress rules to be applied to the
        /// selected pods. Outgoing traffic is allowed if there are no
        /// NetworkPolicies selecting the pod (and cluster policy otherwise
        /// allows the traffic), OR if the traffic matches at least one egress
        /// rule across all of the NetworkPolicy objects whose podSelector
        /// matches the pod. If this field is empty then this NetworkPolicy
        /// limits all outgoing traffic (and serves solely to ensure that the
        /// pods it selects are isolated by default). This field is beta-level
        /// in 1.8</param>
        /// <param name="ingress">List of ingress rules to be applied to the
        /// selected pods. Traffic is allowed to a pod if there are no
        /// NetworkPolicies selecting the pod OR if the traffic source is the
        /// pod's local node, OR if the traffic matches at least one ingress
        /// rule across all of the NetworkPolicy objects whose podSelector
        /// matches the pod. If this field is empty then this NetworkPolicy
        /// does not allow any traffic (and serves solely to ensure that the
        /// pods it selects are isolated by default).</param>
        /// <param name="policyTypes">List of rule types that the NetworkPolicy
        /// relates to. Valid options are Ingress, Egress, or Ingress,Egress.
        /// If this field is not specified, it will default based on the
        /// existence of Ingress or Egress rules; policies that contain an
        /// Egress section are assumed to affect Egress, and all policies
        /// (whether or not they contain an Ingress section) are assumed to
        /// affect Ingress. If you want to write an egress-only policy, you
        /// must explicitly specify policyTypes [ "Egress" ]. Likewise, if you
        /// want to write a policy that specifies that no egress is allowed,
        /// you must specify a policyTypes value that include "Egress" (since
        /// such a policy would not include an Egress section and would
        /// otherwise default to just [ "Ingress" ]). This field is beta-level
        /// in 1.8</param>
        public Apiextensionsv1beta1NetworkPolicySpec(V1LabelSelector podSelector, IList<V1beta1NetworkPolicyEgressRule> egress = default(IList<V1beta1NetworkPolicyEgressRule>), IList<Apiextensionsv1beta1NetworkPolicyIngressRule> ingress = default(IList<Apiextensionsv1beta1NetworkPolicyIngressRule>), IList<string> policyTypes = default(IList<string>))
        {
            Egress = egress;
            Ingress = ingress;
            PodSelector = podSelector;
            PolicyTypes = policyTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of egress rules to be applied to the selected
        /// pods. Outgoing traffic is allowed if there are no NetworkPolicies
        /// selecting the pod (and cluster policy otherwise allows the
        /// traffic), OR if the traffic matches at least one egress rule across
        /// all of the NetworkPolicy objects whose podSelector matches the pod.
        /// If this field is empty then this NetworkPolicy limits all outgoing
        /// traffic (and serves solely to ensure that the pods it selects are
        /// isolated by default). This field is beta-level in 1.8
        /// </summary>
        [JsonProperty(PropertyName = "egress")]
        public IList<V1beta1NetworkPolicyEgressRule> Egress { get; set; }

        /// <summary>
        /// Gets or sets list of ingress rules to be applied to the selected
        /// pods. Traffic is allowed to a pod if there are no NetworkPolicies
        /// selecting the pod OR if the traffic source is the pod's local node,
        /// OR if the traffic matches at least one ingress rule across all of
        /// the NetworkPolicy objects whose podSelector matches the pod. If
        /// this field is empty then this NetworkPolicy does not allow any
        /// traffic (and serves solely to ensure that the pods it selects are
        /// isolated by default).
        /// </summary>
        [JsonProperty(PropertyName = "ingress")]
        public IList<Apiextensionsv1beta1NetworkPolicyIngressRule> Ingress { get; set; }

        /// <summary>
        /// Gets or sets selects the pods to which this NetworkPolicy object
        /// applies.  The array of ingress rules is applied to any pods
        /// selected by this field. Multiple network policies can select the
        /// same set of pods.  In this case, the ingress rules for each are
        /// combined additively. This field is NOT optional and follows
        /// standard label selector semantics. An empty podSelector matches all
        /// pods in this namespace.
        /// </summary>
        [JsonProperty(PropertyName = "podSelector")]
        public V1LabelSelector PodSelector { get; set; }

        /// <summary>
        /// Gets or sets list of rule types that the NetworkPolicy relates to.
        /// Valid options are Ingress, Egress, or Ingress,Egress. If this field
        /// is not specified, it will default based on the existence of Ingress
        /// or Egress rules; policies that contain an Egress section are
        /// assumed to affect Egress, and all policies (whether or not they
        /// contain an Ingress section) are assumed to affect Ingress. If you
        /// want to write an egress-only policy, you must explicitly specify
        /// policyTypes [ "Egress" ]. Likewise, if you want to write a policy
        /// that specifies that no egress is allowed, you must specify a
        /// policyTypes value that include "Egress" (since such a policy would
        /// not include an Egress section and would otherwise default to just [
        /// "Ingress" ]). This field is beta-level in 1.8
        /// </summary>
        [JsonProperty(PropertyName = "policyTypes")]
        public IList<string> PolicyTypes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PodSelector == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PodSelector");
            }
        }
    }
}
