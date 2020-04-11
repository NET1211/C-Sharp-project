// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CustomResourceDefinitionStatus indicates the state of the
    /// CustomResourceDefinition
    /// </summary>
    public partial class V1CustomResourceDefinitionStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1CustomResourceDefinitionStatus
        /// class.
        /// </summary>
        public V1CustomResourceDefinitionStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CustomResourceDefinitionStatus
        /// class.
        /// </summary>
        /// <param name="acceptedNames">acceptedNames are the names that are
        /// actually being used to serve discovery. They may be different than
        /// the names in spec.</param>
        /// <param name="conditions">conditions indicate state for particular
        /// aspects of a CustomResourceDefinition</param>
        /// <param name="storedVersions">storedVersions lists all versions of
        /// CustomResources that were ever persisted. Tracking these versions
        /// allows a migration path for stored versions in etcd. The field is
        /// mutable so a migration controller can finish a migration to another
        /// version (ensuring no old objects are left in storage), and then
        /// remove the rest of the versions from this list. Versions may not be
        /// removed from `spec.versions` while they exist in this list.</param>
        public V1CustomResourceDefinitionStatus(V1CustomResourceDefinitionNames acceptedNames = default(V1CustomResourceDefinitionNames), IList<V1CustomResourceDefinitionCondition> conditions = default(IList<V1CustomResourceDefinitionCondition>), IList<string> storedVersions = default(IList<string>))
        {
            AcceptedNames = acceptedNames;
            Conditions = conditions;
            StoredVersions = storedVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets acceptedNames are the names that are actually being
        /// used to serve discovery. They may be different than the names in
        /// spec.
        /// </summary>
        [JsonProperty(PropertyName = "acceptedNames")]
        public V1CustomResourceDefinitionNames AcceptedNames { get; set; }

        /// <summary>
        /// Gets or sets conditions indicate state for particular aspects of a
        /// CustomResourceDefinition
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V1CustomResourceDefinitionCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets storedVersions lists all versions of CustomResources
        /// that were ever persisted. Tracking these versions allows a
        /// migration path for stored versions in etcd. The field is mutable so
        /// a migration controller can finish a migration to another version
        /// (ensuring no old objects are left in storage), and then remove the
        /// rest of the versions from this list. Versions may not be removed
        /// from `spec.versions` while they exist in this list.
        /// </summary>
        [JsonProperty(PropertyName = "storedVersions")]
        public IList<string> StoredVersions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AcceptedNames != null)
            {
                AcceptedNames.Validate();
            }
            if (Conditions != null)
            {
                foreach (var element in Conditions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
