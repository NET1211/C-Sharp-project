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
    /// APIResource specifies the name of a resource and whether it is namespaced.
    /// </summary>
    public partial class V1APIResource
    {
        /// <summary>
        /// Initializes a new instance of the V1APIResource class.
        /// </summary>
        public V1APIResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1APIResource class.
        /// </summary>
        /// <param name="kind">
        /// kind is the kind for the resource (e.g. &apos;Foo&apos; is the kind for a resource &apos;foo&apos;)
        /// </param>
        /// <param name="name">
        /// name is the plural name of the resource.
        /// </param>
        /// <param name="namespaced">
        /// namespaced indicates if a resource is namespaced or not.
        /// </param>
        /// <param name="singularName">
        /// singularName is the singular name of the resource.  This allows clients to
        /// handle plural and singular opaquely. The singularName is more correct for
        /// reporting status on a single item and both singular and plural are allowed from
        /// the kubectl CLI interface.
        /// </param>
        /// <param name="verbs">
        /// verbs is a list of supported kube verbs (this includes get, list, watch, create,
        /// update, patch, delete, deletecollection, and proxy)
        /// </param>
        /// <param name="categories">
        /// categories is a list of the grouped resources this resource belongs to (e.g.
        /// &apos;all&apos;)
        /// </param>
        /// <param name="group">
        /// group is the preferred group of the resource.  Empty implies the group of the
        /// containing resource list. For subresources, this may have a different value, for
        /// example: Scale&quot;.
        /// </param>
        /// <param name="shortNames">
        /// shortNames is a list of suggested short names of the resource.
        /// </param>
        /// <param name="storageVersionHash">
        /// The hash value of the storage version, the version this resource is converted to
        /// when written to the data store. Value must be treated as opaque by clients. Only
        /// equality comparison on the value is valid. This is an alpha feature and may
        /// change or be removed in the future. The field is populated by the apiserver only
        /// if the StorageVersionHash feature gate is enabled. This field will remain
        /// optional even if it graduates.
        /// </param>
        /// <param name="version">
        /// version is the preferred version of the resource.  Empty implies the version of
        /// the containing resource list For subresources, this may have a different value,
        /// for example: v1 (while inside a v1beta1 version of the core resource&apos;s group)&quot;.
        /// </param>
        public V1APIResource(string kind, string name, bool namespaced, string singularName, IList<string> verbs, IList<string> categories = null, string group = null, IList<string> shortNames = null, string storageVersionHash = null, string version = null)
        {
            Categories = categories;
            Group = group;
            Kind = kind;
            Name = name;
            Namespaced = namespaced;
            ShortNames = shortNames;
            SingularName = singularName;
            StorageVersionHash = storageVersionHash;
            Verbs = verbs;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// categories is a list of the grouped resources this resource belongs to (e.g.
        /// &apos;all&apos;)
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// group is the preferred group of the resource.  Empty implies the group of the
        /// containing resource list. For subresources, this may have a different value, for
        /// example: Scale&quot;.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// kind is the kind for the resource (e.g. &apos;Foo&apos; is the kind for a resource &apos;foo&apos;)
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// name is the plural name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// namespaced indicates if a resource is namespaced or not.
        /// </summary>
        [JsonProperty(PropertyName = "namespaced")]
        public bool Namespaced { get; set; }

        /// <summary>
        /// shortNames is a list of suggested short names of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "shortNames")]
        public IList<string> ShortNames { get; set; }

        /// <summary>
        /// singularName is the singular name of the resource.  This allows clients to
        /// handle plural and singular opaquely. The singularName is more correct for
        /// reporting status on a single item and both singular and plural are allowed from
        /// the kubectl CLI interface.
        /// </summary>
        [JsonProperty(PropertyName = "singularName")]
        public string SingularName { get; set; }

        /// <summary>
        /// The hash value of the storage version, the version this resource is converted to
        /// when written to the data store. Value must be treated as opaque by clients. Only
        /// equality comparison on the value is valid. This is an alpha feature and may
        /// change or be removed in the future. The field is populated by the apiserver only
        /// if the StorageVersionHash feature gate is enabled. This field will remain
        /// optional even if it graduates.
        /// </summary>
        [JsonProperty(PropertyName = "storageVersionHash")]
        public string StorageVersionHash { get; set; }

        /// <summary>
        /// verbs is a list of supported kube verbs (this includes get, list, watch, create,
        /// update, patch, delete, deletecollection, and proxy)
        /// </summary>
        [JsonProperty(PropertyName = "verbs")]
        public IList<string> Verbs { get; set; }

        /// <summary>
        /// version is the preferred version of the resource.  Empty implies the version of
        /// the containing resource list For subresources, this may have a different value,
        /// for example: v1 (while inside a v1beta1 version of the core resource&apos;s group)&quot;.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

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
