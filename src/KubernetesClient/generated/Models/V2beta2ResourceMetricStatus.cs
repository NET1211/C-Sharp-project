// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ResourceMetricStatus indicates the current value of a resource metric known to
        /// Kubernetes, as specified in requests and limits, describing each pod in the
        /// current scale target (e.g. CPU or memory).  Such metrics are built in to
        /// Kubernetes, and have special scaling options on top of those available to normal
        /// per-pod metrics using the &quot;pods&quot; source.
    /// </summary>
    public partial class V2beta2ResourceMetricStatus
    {
        /// <summary>
        /// Initializes a new instance of the V2beta2ResourceMetricStatus class.
        /// </summary>
        public V2beta2ResourceMetricStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta2ResourceMetricStatus class.
        /// </summary>
        /// <param name="current">
        /// current contains the current value for the given metric
        /// </param>
        /// <param name="name">
        /// Name is the name of the resource in question.
        /// </param>
        public V2beta2ResourceMetricStatus(V2beta2MetricValueStatus current, string name)
        {
            Current = current;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// current contains the current value for the given metric
        /// </summary>
        [JsonPropertyName("current")]
        public V2beta2MetricValueStatus Current { get; set; }

        /// <summary>
        /// Name is the name of the resource in question.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Current == null)
            {
                throw new ArgumentNullException("Current");    
            }
            Current?.Validate();
        }
    }
}
