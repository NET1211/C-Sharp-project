// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// CronJobStatus represents the current state of a cron job.
    /// </summary>
    public partial class V1beta1CronJobStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1CronJobStatus class.
        /// </summary>
        public V1beta1CronJobStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1CronJobStatus class.
        /// </summary>
        /// <param name="active">
        /// A list of pointers to currently running jobs.
        /// </param>
        /// <param name="lastScheduleTime">
        /// Information when was the last time the job was successfully scheduled.
        /// </param>
        /// <param name="lastSuccessfulTime">
        /// Information when was the last time the job successfully completed.
        /// </param>
        public V1beta1CronJobStatus(IList<V1ObjectReference> active = null, System.DateTime? lastScheduleTime = null, System.DateTime? lastSuccessfulTime = null)
        {
            Active = active;
            LastScheduleTime = lastScheduleTime;
            LastSuccessfulTime = lastSuccessfulTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// A list of pointers to currently running jobs.
        /// </summary>
        [JsonPropertyName("active")]
        public IList<V1ObjectReference> Active { get; set; }

        /// <summary>
        /// Information when was the last time the job was successfully scheduled.
        /// </summary>
        [JsonPropertyName("lastScheduleTime")]
        public System.DateTime? LastScheduleTime { get; set; }

        /// <summary>
        /// Information when was the last time the job successfully completed.
        /// </summary>
        [JsonPropertyName("lastSuccessfulTime")]
        public System.DateTime? LastSuccessfulTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Active != null){
                foreach(var obj in Active)
                {
                    obj.Validate();
                }
            }
        }
    }
}
