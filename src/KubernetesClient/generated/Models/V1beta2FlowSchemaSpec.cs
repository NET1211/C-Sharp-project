// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// FlowSchemaSpec describes how the FlowSchema&apos;s specification looks like.
    /// </summary>
    public partial class V1beta2FlowSchemaSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta2FlowSchemaSpec class.
        /// </summary>
        public V1beta2FlowSchemaSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta2FlowSchemaSpec class.
        /// </summary>
        /// <param name="priorityLevelConfiguration">
        /// `priorityLevelConfiguration` should reference a PriorityLevelConfiguration in
        /// the cluster. If the reference cannot be resolved, the FlowSchema will be ignored
        /// and marked as invalid in its status. Required.
        /// </param>
        /// <param name="distinguisherMethod">
        /// `distinguisherMethod` defines how to compute the flow distinguisher for requests
        /// that match this schema. `nil` specifies that the distinguisher is disabled and
        /// thus will always be the empty string.
        /// </param>
        /// <param name="matchingPrecedence">
        /// `matchingPrecedence` is used to choose among the FlowSchemas that match a given
        /// request. The chosen FlowSchema is among those with the numerically lowest (which
        /// we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence
        /// value must be ranged in [1,10000]. Note that if the precedence is not specified,
        /// it will be set to 1000 as default.
        /// </param>
        /// <param name="rules">
        /// `rules` describes which requests will match this flow schema. This FlowSchema
        /// matches a request if and only if at least one member of rules matches the
        /// request. if it is an empty slice, there will be no requests matching the
        /// FlowSchema.
        /// </param>
        public V1beta2FlowSchemaSpec(V1beta2PriorityLevelConfigurationReference priorityLevelConfiguration, V1beta2FlowDistinguisherMethod distinguisherMethod = null, int? matchingPrecedence = null, IList<V1beta2PolicyRulesWithSubjects> rules = null)
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
        /// `distinguisherMethod` defines how to compute the flow distinguisher for requests
        /// that match this schema. `nil` specifies that the distinguisher is disabled and
        /// thus will always be the empty string.
        /// </summary>
        [JsonPropertyName("distinguisherMethod")]
        public V1beta2FlowDistinguisherMethod DistinguisherMethod { get; set; }

        /// <summary>
        /// `matchingPrecedence` is used to choose among the FlowSchemas that match a given
        /// request. The chosen FlowSchema is among those with the numerically lowest (which
        /// we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence
        /// value must be ranged in [1,10000]. Note that if the precedence is not specified,
        /// it will be set to 1000 as default.
        /// </summary>
        [JsonPropertyName("matchingPrecedence")]
        public int? MatchingPrecedence { get; set; }

        /// <summary>
        /// `priorityLevelConfiguration` should reference a PriorityLevelConfiguration in
        /// the cluster. If the reference cannot be resolved, the FlowSchema will be ignored
        /// and marked as invalid in its status. Required.
        /// </summary>
        [JsonPropertyName("priorityLevelConfiguration")]
        public V1beta2PriorityLevelConfigurationReference PriorityLevelConfiguration { get; set; }

        /// <summary>
        /// `rules` describes which requests will match this flow schema. This FlowSchema
        /// matches a request if and only if at least one member of rules matches the
        /// request. if it is an empty slice, there will be no requests matching the
        /// FlowSchema.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<V1beta2PolicyRulesWithSubjects> Rules { get; set; }

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
                throw new ArgumentNullException("PriorityLevelConfiguration");    
            }
            DistinguisherMethod?.Validate();
            PriorityLevelConfiguration?.Validate();
            if (Rules != null){
                foreach(var obj in Rules)
                {
                    obj.Validate();
                }
            }
        }
    }
}