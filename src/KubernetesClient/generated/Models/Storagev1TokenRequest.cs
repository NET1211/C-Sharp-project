// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// TokenRequest contains parameters of a service account token.
    /// </summary>
    public partial class Storagev1TokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the Storagev1TokenRequest class.
        /// </summary>
        public Storagev1TokenRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Storagev1TokenRequest class.
        /// </summary>
        /// <param name="audience">
        /// Audience is the intended audience of the token in &quot;TokenRequestSpec&quot;. It will
        /// default to the audiences of kube apiserver.
        /// </param>
        /// <param name="expirationSeconds">
        /// ExpirationSeconds is the duration of validity of the token in
        /// &quot;TokenRequestSpec&quot;. It has the same default value of &quot;ExpirationSeconds&quot; in
        /// &quot;TokenRequestSpec&quot;.
        /// </param>
        public Storagev1TokenRequest(string audience, long? expirationSeconds = null)
        {
            Audience = audience;
            ExpirationSeconds = expirationSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Audience is the intended audience of the token in &quot;TokenRequestSpec&quot;. It will
        /// default to the audiences of kube apiserver.
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// ExpirationSeconds is the duration of validity of the token in
        /// &quot;TokenRequestSpec&quot;. It has the same default value of &quot;ExpirationSeconds&quot; in
        /// &quot;TokenRequestSpec&quot;.
        /// </summary>
        [JsonPropertyName("expirationSeconds")]
        public long? ExpirationSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
