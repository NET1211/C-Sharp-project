// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ResourceMetricSource indicates how to scale on a resource metric known to
        /// Kubernetes, as specified in requests and limits, describing each pod in the
        /// current scale target (e.g. CPU or memory).  The values will be averaged together
        /// before being compared to the target.  Such metrics are built in to Kubernetes,
        /// and have special scaling options on top of those available to normal per-pod
        /// metrics using the &quot;pods&quot; source.  Only one &quot;target&quot; type should be set.
    /// </summary>
    public partial class V2beta1ResourceMetricSource
    {
        /// <summary>
        /// Initializes a new instance of the V2beta1ResourceMetricSource class.
        /// </summary>
        public V2beta1ResourceMetricSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta1ResourceMetricSource class.
        /// </summary>
        /// <param name="name">
        /// name is the name of the resource in question.
        /// </param>
        /// <param name="targetAverageUtilization">
        /// targetAverageUtilization is the target value of the average of the resource
        /// metric across all relevant pods, represented as a percentage of the requested
        /// value of the resource for the pods.
        /// </param>
        /// <param name="targetAverageValue">
        /// targetAverageValue is the target value of the average of the resource metric
        /// across all relevant pods, as a raw value (instead of as a percentage of the
        /// request), similar to the &quot;pods&quot; metric source type.
        /// </param>
        public V2beta1ResourceMetricSource(string name, int? targetAverageUtilization = null, ResourceQuantity targetAverageValue = null)
        {
            Name = name;
            TargetAverageUtilization = targetAverageUtilization;
            TargetAverageValue = targetAverageValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// name is the name of the resource in question.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// targetAverageUtilization is the target value of the average of the resource
        /// metric across all relevant pods, represented as a percentage of the requested
        /// value of the resource for the pods.
        /// </summary>
        [JsonPropertyName("targetAverageUtilization")]
        public int? TargetAverageUtilization { get; set; }

        /// <summary>
        /// targetAverageValue is the target value of the average of the resource metric
        /// across all relevant pods, as a raw value (instead of as a percentage of the
        /// request), similar to the &quot;pods&quot; metric source type.
        /// </summary>
        [JsonPropertyName("targetAverageValue")]
        public ResourceQuantity TargetAverageValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            TargetAverageValue?.Validate();
        }
    }
}
