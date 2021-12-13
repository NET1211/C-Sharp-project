// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// DeploymentStrategy describes how to replace existing pods with new ones.
    /// </summary>
    public partial class V1DeploymentStrategy
    {
        /// <summary>
        /// Initializes a new instance of the V1DeploymentStrategy class.
        /// </summary>
        public V1DeploymentStrategy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1DeploymentStrategy class.
        /// </summary>
        /// <param name="rollingUpdate">
        /// Rolling update config params. Present only if DeploymentStrategyType =
        /// RollingUpdate.
        /// </param>
        /// <param name="type">
        /// Type of deployment. Can be &quot;Recreate&quot; or &quot;RollingUpdate&quot;. Default is
        /// RollingUpdate.
        /// 
        /// Possible enum values:
        /// - `&quot;Recreate&quot;` Kill all existing pods before creating new ones.
        /// - `&quot;RollingUpdate&quot;` Replace the old ReplicaSets by new one using rolling update
        /// i.e gradually scale down the old ReplicaSets and scale up the new one.
        /// </param>
        public V1DeploymentStrategy(V1RollingUpdateDeployment rollingUpdate = null, string type = null)
        {
            RollingUpdate = rollingUpdate;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Rolling update config params. Present only if DeploymentStrategyType =
        /// RollingUpdate.
        /// </summary>
        [JsonPropertyName("rollingUpdate")]
        public V1RollingUpdateDeployment RollingUpdate { get; set; }

        /// <summary>
        /// Type of deployment. Can be &quot;Recreate&quot; or &quot;RollingUpdate&quot;. Default is
        /// RollingUpdate.
        /// 
        /// Possible enum values:
        /// - `&quot;Recreate&quot;` Kill all existing pods before creating new ones.
        /// - `&quot;RollingUpdate&quot;` Replace the old ReplicaSets by new one using rolling update
        /// i.e gradually scale down the old ReplicaSets and scale up the new one.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            RollingUpdate?.Validate();
        }
    }
}
