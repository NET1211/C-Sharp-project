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

    /// <summary>
    /// FlowSchemaSpec describes how the FlowSchema's specification looks like.
    /// </summary>
    public partial class V1beta1FlowSchemaSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1FlowSchemaSpec class.
        /// </summary>
        public V1beta1FlowSchemaSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1FlowSchemaSpec class.
        /// </summary>
        /// <param
        /// name="priorityLevelConfiguration">`priorityLevelConfiguration`
        /// should reference a PriorityLevelConfiguration in the cluster. If
        /// the reference cannot be resolved, the FlowSchema will be ignored
        /// and marked as invalid in its status. Required.</param>
        /// <param name="distinguisherMethod">`distinguisherMethod` defines how
        /// to compute the flow distinguisher for requests that match this
        /// schema. `nil` specifies that the distinguisher is disabled and thus
        /// will always be the empty string.</param>
        /// <param name="matchingPrecedence">`matchingPrecedence` is used to
        /// choose among the FlowSchemas that match a given request. The chosen
        /// FlowSchema is among those with the numerically lowest (which we
        /// take to be logically highest) MatchingPrecedence.  Each
        /// MatchingPrecedence value must be ranged in [1,10000]. Note that if
        /// the precedence is not specified, it will be set to 1000 as
        /// default.</param>
        /// <param name="rules">`rules` describes which requests will match
        /// this flow schema. This FlowSchema matches a request if and only if
        /// at least one member of rules matches the request. if it is an empty
        /// slice, there will be no requests matching the FlowSchema.</param>
        public V1beta1FlowSchemaSpec(V1beta1PriorityLevelConfigurationReference priorityLevelConfiguration, V1beta1FlowDistinguisherMethod distinguisherMethod = default(V1beta1FlowDistinguisherMethod), int? matchingPrecedence = default(int?), IList<V1beta1PolicyRulesWithSubjects> rules = default(IList<V1beta1PolicyRulesWithSubjects>))
        {
            DistinguisherMethod = distinguisherMethod;
            MatchingPrecedence = matchingPrecedence;
            PriorityLevelConfiguration = priorityLevelConfiguration;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets `distinguisherMethod` defines how to compute the flow
        /// distinguisher for requests that match this schema. `nil` specifies
        /// that the distinguisher is disabled and thus will always be the
        /// empty string.
        /// </summary>
        [JsonProperty(PropertyName = "distinguisherMethod")]
        public V1beta1FlowDistinguisherMethod DistinguisherMethod { get; set; }

        /// <summary>
        /// Gets or sets `matchingPrecedence` is used to choose among the
        /// FlowSchemas that match a given request. The chosen FlowSchema is
        /// among those with the numerically lowest (which we take to be
        /// logically highest) MatchingPrecedence.  Each MatchingPrecedence
        /// value must be ranged in [1,10000]. Note that if the precedence is
        /// not specified, it will be set to 1000 as default.
        /// </summary>
        [JsonProperty(PropertyName = "matchingPrecedence")]
        public int? MatchingPrecedence { get; set; }

        /// <summary>
        /// Gets or sets `priorityLevelConfiguration` should reference a
        /// PriorityLevelConfiguration in the cluster. If the reference cannot
        /// be resolved, the FlowSchema will be ignored and marked as invalid
        /// in its status. Required.
        /// </summary>
        [JsonProperty(PropertyName = "priorityLevelConfiguration")]
        public V1beta1PriorityLevelConfigurationReference PriorityLevelConfiguration { get; set; }

        /// <summary>
        /// Gets or sets `rules` describes which requests will match this flow
        /// schema. This FlowSchema matches a request if and only if at least
        /// one member of rules matches the request. if it is an empty slice,
        /// there will be no requests matching the FlowSchema.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<V1beta1PolicyRulesWithSubjects> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PriorityLevelConfiguration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PriorityLevelConfiguration");
            }
            if (DistinguisherMethod != null)
            {
                DistinguisherMethod.Validate();
            }
            if (PriorityLevelConfiguration != null)
            {
                PriorityLevelConfiguration.Validate();
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
