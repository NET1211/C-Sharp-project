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
    /// WebhookConversion describes how to call a conversion webhook
    /// </summary>
    public partial class V1WebhookConversion
    {
        /// <summary>
        /// Initializes a new instance of the V1WebhookConversion class.
        /// </summary>
        public V1WebhookConversion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1WebhookConversion class.
        /// </summary>
        /// <param name="conversionReviewVersions">
        /// conversionReviewVersions is an ordered list of preferred `ConversionReview`
        /// versions the Webhook expects. The API server will use the first version in the
        /// list which it supports. If none of the versions specified in this list are
        /// supported by API server, conversion will fail for the custom resource. If a
        /// persisted Webhook configuration specifies allowed versions and does not include
        /// any versions known to the API Server, calls to the webhook will fail.
        /// </param>
        /// <param name="clientConfig">
        /// clientConfig is the instructions for how to call the webhook if strategy is
        /// `Webhook`.
        /// </param>
        public V1WebhookConversion(IList<string> conversionReviewVersions, Apiextensionsv1WebhookClientConfig clientConfig = null)
        {
            ClientConfig = clientConfig;
            ConversionReviewVersions = conversionReviewVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// clientConfig is the instructions for how to call the webhook if strategy is
        /// `Webhook`.
        /// </summary>
        [JsonProperty(PropertyName = "clientConfig")]
        public Apiextensionsv1WebhookClientConfig ClientConfig { get; set; }

        /// <summary>
        /// conversionReviewVersions is an ordered list of preferred `ConversionReview`
        /// versions the Webhook expects. The API server will use the first version in the
        /// list which it supports. If none of the versions specified in this list are
        /// supported by API server, conversion will fail for the custom resource. If a
        /// persisted Webhook configuration specifies allowed versions and does not include
        /// any versions known to the API Server, calls to the webhook will fail.
        /// </summary>
        [JsonProperty(PropertyName = "conversionReviewVersions")]
        public IList<string> ConversionReviewVersions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            ClientConfig?.Validate();
        }
    }
}
