// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DeploymentStrategy describes how to replace existing pods with new
    /// ones.
    /// </summary>
    public partial class Appsv1beta1DeploymentStrategy
    {
        /// <summary>
        /// Initializes a new instance of the Appsv1beta1DeploymentStrategy
        /// class.
        /// </summary>
        public Appsv1beta1DeploymentStrategy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Appsv1beta1DeploymentStrategy
        /// class.
        /// </summary>
        /// <param name="rollingUpdate">Rolling update config params. Present
        /// only if DeploymentStrategyType = RollingUpdate.</param>
        /// <param name="type">Type of deployment. Can be "Recreate" or
        /// "RollingUpdate". Default is RollingUpdate.</param>
        public Appsv1beta1DeploymentStrategy(Appsv1beta1RollingUpdateDeployment rollingUpdate = default(Appsv1beta1RollingUpdateDeployment), string type = default(string))
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
        /// Gets or sets rolling update config params. Present only if
        /// DeploymentStrategyType = RollingUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpdate")]
        public Appsv1beta1RollingUpdateDeployment RollingUpdate { get; set; }

        /// <summary>
        /// Gets or sets type of deployment. Can be "Recreate" or
        /// "RollingUpdate". Default is RollingUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
