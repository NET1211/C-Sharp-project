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
    /// ResourceRule is the list of actions the subject is allowed to perform
    /// on resources. The list ordering isn't significant, may contain
    /// duplicates, and possibly be incomplete.
    /// </summary>
    public partial class V1beta1ResourceRule
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1ResourceRule class.
        /// </summary>
        public V1beta1ResourceRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1ResourceRule class.
        /// </summary>
        /// <param name="verbs">Verb is a list of kubernetes resource API
        /// verbs, like: get, list, watch, create, update, delete, proxy.  "*"
        /// means all.</param>
        /// <param name="apiGroups">APIGroups is the name of the APIGroup that
        /// contains the resources.  If multiple API groups are specified, any
        /// action requested against one of the enumerated resources in any API
        /// group will be allowed.  "*" means all.</param>
        /// <param name="resourceNames">ResourceNames is an optional white list
        /// of names that the rule applies to.  An empty set means that
        /// everything is allowed.  "*" means all.</param>
        /// <param name="resources">Resources is a list of resources this rule
        /// applies to.  ResourceAll represents all resources.  "*" means
        /// all.</param>
        public V1beta1ResourceRule(IList<string> verbs, IList<string> apiGroups = default(IList<string>), IList<string> resourceNames = default(IList<string>), IList<string> resources = default(IList<string>))
        {
            ApiGroups = apiGroups;
            ResourceNames = resourceNames;
            Resources = resources;
            Verbs = verbs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIGroups is the name of the APIGroup that contains
        /// the resources.  If multiple API groups are specified, any action
        /// requested against one of the enumerated resources in any API group
        /// will be allowed.  "*" means all.
        /// </summary>
        [JsonProperty(PropertyName = "apiGroups")]
        public IList<string> ApiGroups { get; set; }

        /// <summary>
        /// Gets or sets resourceNames is an optional white list of names that
        /// the rule applies to.  An empty set means that everything is
        /// allowed.  "*" means all.
        /// </summary>
        [JsonProperty(PropertyName = "resourceNames")]
        public IList<string> ResourceNames { get; set; }

        /// <summary>
        /// Gets or sets resources is a list of resources this rule applies to.
        /// ResourceAll represents all resources.  "*" means all.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        /// Gets or sets verb is a list of kubernetes resource API verbs, like:
        /// get, list, watch, create, update, delete, proxy.  "*" means all.
        /// </summary>
        [JsonProperty(PropertyName = "verbs")]
        public IList<string> Verbs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Verbs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Verbs");
            }
        }
    }
}
