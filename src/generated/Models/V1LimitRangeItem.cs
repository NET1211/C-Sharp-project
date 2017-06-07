// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// LimitRangeItem defines a min/max usage limit for any resource that
    /// matches on kind.
    /// </summary>
    public partial class V1LimitRangeItem
    {
        /// <summary>
        /// Initializes a new instance of the V1LimitRangeItem class.
        /// </summary>
        public V1LimitRangeItem()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1LimitRangeItem class.
        /// </summary>
        /// <param name="defaultProperty">Default resource requirement limit
        /// value by resource name if resource limit is omitted.</param>
        /// <param name="defaultRequest">DefaultRequest is the default resource
        /// requirement request value by resource name if resource request is
        /// omitted.</param>
        /// <param name="max">Max usage constraints on this kind by resource
        /// name.</param>
        /// <param name="maxLimitRequestRatio">MaxLimitRequestRatio if
        /// specified, the named resource must have a request and limit that
        /// are both non-zero where limit divided by request is less than or
        /// equal to the enumerated value; this represents the max burst for
        /// the named resource.</param>
        /// <param name="min">Min usage constraints on this kind by resource
        /// name.</param>
        /// <param name="type">Type of resource that this limit applies
        /// to.</param>
        public V1LimitRangeItem(IDictionary<string, string> defaultProperty = default(IDictionary<string, string>), IDictionary<string, string> defaultRequest = default(IDictionary<string, string>), IDictionary<string, string> max = default(IDictionary<string, string>), IDictionary<string, string> maxLimitRequestRatio = default(IDictionary<string, string>), IDictionary<string, string> min = default(IDictionary<string, string>), string type = default(string))
        {
            DefaultProperty = defaultProperty;
            DefaultRequest = defaultRequest;
            Max = max;
            MaxLimitRequestRatio = maxLimitRequestRatio;
            Min = min;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets default resource requirement limit value by resource
        /// name if resource limit is omitted.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public IDictionary<string, string> DefaultProperty { get; set; }

        /// <summary>
        /// Gets or sets defaultRequest is the default resource requirement
        /// request value by resource name if resource request is omitted.
        /// </summary>
        [JsonProperty(PropertyName = "defaultRequest")]
        public IDictionary<string, string> DefaultRequest { get; set; }

        /// <summary>
        /// Gets or sets max usage constraints on this kind by resource name.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public IDictionary<string, string> Max { get; set; }

        /// <summary>
        /// Gets or sets maxLimitRequestRatio if specified, the named resource
        /// must have a request and limit that are both non-zero where limit
        /// divided by request is less than or equal to the enumerated value;
        /// this represents the max burst for the named resource.
        /// </summary>
        [JsonProperty(PropertyName = "maxLimitRequestRatio")]
        public IDictionary<string, string> MaxLimitRequestRatio { get; set; }

        /// <summary>
        /// Gets or sets min usage constraints on this kind by resource name.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public IDictionary<string, string> Min { get; set; }

        /// <summary>
        /// Gets or sets type of resource that this limit applies to.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
