// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// JSONSchemaPropsOrArray represents a value that can either be a
    /// JSONSchemaProps or an array of JSONSchemaProps. Mainly here for
    /// serialization purposes.
    /// </summary>
    public partial class V1beta1JSONSchemaPropsOrArray
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1JSONSchemaPropsOrArray
        /// class.
        /// </summary>
        public V1beta1JSONSchemaPropsOrArray()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1JSONSchemaPropsOrArray
        /// class.
        /// </summary>
        public V1beta1JSONSchemaPropsOrArray(IList<V1beta1JSONSchemaProps> jSONSchemas, V1beta1JSONSchemaProps schema)
        {
            JSONSchemas = jSONSchemas;
            Schema = schema;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JSONSchemas")]
        public IList<V1beta1JSONSchemaProps> JSONSchemas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Schema")]
        public V1beta1JSONSchemaProps Schema { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (JSONSchemas == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JSONSchemas");
            }
            if (Schema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schema");
            }
            if (JSONSchemas != null)
            {
                foreach (var element in JSONSchemas)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Schema != null)
            {
                Schema.Validate();
            }
        }
    }
}
