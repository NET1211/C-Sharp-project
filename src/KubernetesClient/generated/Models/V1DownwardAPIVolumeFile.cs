// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DownwardAPIVolumeFile represents information to create the file
    /// containing the pod field
    /// </summary>
    public partial class V1DownwardAPIVolumeFile
    {
        /// <summary>
        /// Initializes a new instance of the V1DownwardAPIVolumeFile class.
        /// </summary>
        public V1DownwardAPIVolumeFile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1DownwardAPIVolumeFile class.
        /// </summary>
        /// <param name="path">Required: Path is  the relative path name of the
        /// file to be created. Must not be absolute or contain the '..' path.
        /// Must be utf-8 encoded. The first item of the relative path must not
        /// start with '..'</param>
        /// <param name="fieldRef">Required: Selects a field of the pod: only
        /// annotations, labels, name and namespace are supported.</param>
        /// <param name="mode">Optional: mode bits used to set permissions on
        /// this file, must be an octal value between 0000 and 0777 or a
        /// decimal value between 0 and 511. YAML accepts both octal and
        /// decimal values, JSON requires decimal values for mode bits. If not
        /// specified, the volume defaultMode will be used. This might be in
        /// conflict with other options that affect the file mode, like
        /// fsGroup, and the result can be other mode bits set.</param>
        /// <param name="resourceFieldRef">Selects a resource of the container:
        /// only resources limits and requests (limits.cpu, limits.memory,
        /// requests.cpu and requests.memory) are currently supported.</param>
        public V1DownwardAPIVolumeFile(string path, V1ObjectFieldSelector fieldRef = default(V1ObjectFieldSelector), int? mode = default(int?), V1ResourceFieldSelector resourceFieldRef = default(V1ResourceFieldSelector))
        {
            FieldRef = fieldRef;
            Mode = mode;
            Path = path;
            ResourceFieldRef = resourceFieldRef;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required: Selects a field of the pod: only
        /// annotations, labels, name and namespace are supported.
        /// </summary>
        [JsonProperty(PropertyName = "fieldRef")]
        public V1ObjectFieldSelector FieldRef { get; set; }

        /// <summary>
        /// Gets or sets optional: mode bits used to set permissions on this
        /// file, must be an octal value between 0000 and 0777 or a decimal
        /// value between 0 and 511. YAML accepts both octal and decimal
        /// values, JSON requires decimal values for mode bits. If not
        /// specified, the volume defaultMode will be used. This might be in
        /// conflict with other options that affect the file mode, like
        /// fsGroup, and the result can be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// Gets or sets required: Path is  the relative path name of the file
        /// to be created. Must not be absolute or contain the '..' path. Must
        /// be utf-8 encoded. The first item of the relative path must not
        /// start with '..'
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets selects a resource of the container: only resources
        /// limits and requests (limits.cpu, limits.memory, requests.cpu and
        /// requests.memory) are currently supported.
        /// </summary>
        [JsonProperty(PropertyName = "resourceFieldRef")]
        public V1ResourceFieldSelector ResourceFieldRef { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (FieldRef != null)
            {
                FieldRef.Validate();
            }
            if (ResourceFieldRef != null)
            {
                ResourceFieldRef.Validate();
            }
        }
    }
}
