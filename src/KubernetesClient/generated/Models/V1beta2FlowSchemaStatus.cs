// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// FlowSchemaStatus represents the current state of a FlowSchema.
    /// </summary>
    public partial class V1beta2FlowSchemaStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1beta2FlowSchemaStatus class.
        /// </summary>
        public V1beta2FlowSchemaStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta2FlowSchemaStatus class.
        /// </summary>
        /// <param name="conditions">
        /// `conditions` is a list of the current states of FlowSchema.
        /// </param>
        public V1beta2FlowSchemaStatus(IList<V1beta2FlowSchemaCondition> conditions = null)
        {
            Conditions = conditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// `conditions` is a list of the current states of FlowSchema.
        /// </summary>
        [JsonPropertyName("conditions")]
        public IList<V1beta2FlowSchemaCondition> Conditions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null){
                foreach(var obj in Conditions)
                {
                    obj.Validate();
                }
            }
        }
    }
}