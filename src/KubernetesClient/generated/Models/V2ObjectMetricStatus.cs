// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ObjectMetricStatus indicates the current value of a metric describing a
        /// kubernetes object (for example, hits-per-second on an Ingress object).
    /// </summary>
    public partial class V2ObjectMetricStatus
    {
        /// <summary>
        /// Initializes a new instance of the V2ObjectMetricStatus class.
        /// </summary>
        public V2ObjectMetricStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2ObjectMetricStatus class.
        /// </summary>
        /// <param name="current">
        /// current contains the current value for the given metric
        /// </param>
        /// <param name="describedObject">
        /// DescribedObject specifies the descriptions of a object,such as kind,name
        /// apiVersion
        /// </param>
        /// <param name="metric">
        /// metric identifies the target metric by name and selector
        /// </param>
        public V2ObjectMetricStatus(V2MetricValueStatus current, V2CrossVersionObjectReference describedObject, V2MetricIdentifier metric)
        {
            Current = current;
            DescribedObject = describedObject;
            Metric = metric;
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
        public V2MetricValueStatus Current { get; set; }

        /// <summary>
        /// DescribedObject specifies the descriptions of a object,such as kind,name
        /// apiVersion
        /// </summary>
        [JsonPropertyName("describedObject")]
        public V2CrossVersionObjectReference DescribedObject { get; set; }

        /// <summary>
        /// metric identifies the target metric by name and selector
        /// </summary>
        [JsonPropertyName("metric")]
        public V2MetricIdentifier Metric { get; set; }

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
            if (DescribedObject == null)
            {
                throw new ArgumentNullException("DescribedObject");    
            }
            if (Metric == null)
            {
                throw new ArgumentNullException("Metric");    
            }
            Current?.Validate();
            DescribedObject?.Validate();
            Metric?.Validate();
        }
    }
}