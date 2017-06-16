// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a set of pods (namely those matching the labelSelector relative
    /// to the given namespace(s)) that this pod should be co-located
    /// (affinity) or not co-located (anti-affinity) with, where co-located is
    /// defined as running on a node whose value of the label with key
    /// &lt;topologyKey&gt; tches that of any node on which a pod of the set of
    /// pods is running
    /// </summary>
    public partial class V1PodAffinityTerm
    {
        /// <summary>
        /// Initializes a new instance of the V1PodAffinityTerm class.
        /// </summary>
        public V1PodAffinityTerm()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PodAffinityTerm class.
        /// </summary>
        /// <param name="labelSelector">A label query over a set of resources,
        /// in this case pods.</param>
        /// <param name="namespaces">namespaces specifies which namespaces the
        /// labelSelector applies to (matches against); null or empty list
        /// means "this pod's namespace"</param>
        /// <param name="topologyKey">This pod should be co-located (affinity)
        /// or not co-located (anti-affinity) with the pods matching the
        /// labelSelector in the specified namespaces, where co-located is
        /// defined as running on a node whose value of the label with key
        /// topologyKey matches that of any node on which any of the selected
        /// pods is running. For PreferredDuringScheduling pod anti-affinity,
        /// empty topologyKey is interpreted as "all topologies" ("all
        /// topologies" here means all the topologyKeys indicated by scheduler
        /// command-line argument --failure-domains); for affinity and for
        /// RequiredDuringScheduling pod anti-affinity, empty topologyKey is
        /// not allowed.</param>
        public V1PodAffinityTerm(V1LabelSelector labelSelector = default(V1LabelSelector), IList<string> namespaces = default(IList<string>), string topologyKey = default(string))
        {
            LabelSelector = labelSelector;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a label query over a set of resources, in this case
        /// pods.
        /// </summary>
        [JsonProperty(PropertyName = "labelSelector")]
        public V1LabelSelector LabelSelector { get; set; }

        /// <summary>
        /// Gets or sets namespaces specifies which namespaces the
        /// labelSelector applies to (matches against); null or empty list
        /// means "this pod's namespace"
        /// </summary>
        [JsonProperty(PropertyName = "namespaces")]
        public IList<string> Namespaces { get; set; }

        /// <summary>
        /// Gets or sets this pod should be co-located (affinity) or not
        /// co-located (anti-affinity) with the pods matching the labelSelector
        /// in the specified namespaces, where co-located is defined as running
        /// on a node whose value of the label with key topologyKey matches
        /// that of any node on which any of the selected pods is running. For
        /// PreferredDuringScheduling pod anti-affinity, empty topologyKey is
        /// interpreted as "all topologies" ("all topologies" here means all
        /// the topologyKeys indicated by scheduler command-line argument
        /// --failure-domains); for affinity and for RequiredDuringScheduling
        /// pod anti-affinity, empty topologyKey is not allowed.
        /// </summary>
        [JsonProperty(PropertyName = "topologyKey")]
        public string TopologyKey { get; set; }

    }
}
