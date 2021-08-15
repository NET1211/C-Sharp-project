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
    /// RunAsGroupStrategyOptions defines the strategy type and any options used to
        /// create the strategy.
    /// </summary>
    public partial class V1beta1RunAsGroupStrategyOptions
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1RunAsGroupStrategyOptions class.
        /// </summary>
        public V1beta1RunAsGroupStrategyOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1RunAsGroupStrategyOptions class.
        /// </summary>
        /// <param name="rule">
        /// rule is the strategy that will dictate the allowable RunAsGroup values that may
        /// be set.
        /// </param>
        /// <param name="ranges">
        /// ranges are the allowed ranges of gids that may be used. If you would like to
        /// force a single gid then supply a single range with the same start and end.
        /// Required for MustRunAs.
        /// </param>
        public V1beta1RunAsGroupStrategyOptions(string rule, IList<V1beta1IDRange> ranges = null)
        {
            Ranges = ranges;
            Rule = rule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// ranges are the allowed ranges of gids that may be used. If you would like to
        /// force a single gid then supply a single range with the same start and end.
        /// Required for MustRunAs.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<V1beta1IDRange> Ranges { get; set; }

        /// <summary>
        /// rule is the strategy that will dictate the allowable RunAsGroup values that may
        /// be set.
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string Rule { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            foreach(var obj in Ranges)
            {
                obj.Validate();
            }
        }
    }
}
