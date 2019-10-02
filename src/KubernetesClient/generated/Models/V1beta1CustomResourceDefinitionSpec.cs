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
    /// CustomResourceDefinitionSpec describes how a user wants their resource
    /// to appear
    /// </summary>
    public partial class V1beta1CustomResourceDefinitionSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceDefinitionSpec class.
        /// </summary>
        public V1beta1CustomResourceDefinitionSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceDefinitionSpec class.
        /// </summary>
        /// <param name="group">group is the API group of the defined custom
        /// resource. The custom resources are served under
        /// `/apis/&lt;group&gt;/...`. Must match the name of the
        /// CustomResourceDefinition (in the form
        /// `&lt;names.plural&gt;.&lt;group&gt;`).</param>
        /// <param name="names">names specify the resource and kind names for
        /// the custom resource.</param>
        /// <param name="scope">scope indicates whether the defined custom
        /// resource is cluster- or namespace-scoped. Allowed values are
        /// `Cluster` and `Namespaced`. Default is `Namespaced`.</param>
        /// <param name="additionalPrinterColumns">additionalPrinterColumns
        /// specifies additional columns returned in Table output. See
        /// https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables
        /// for details. If present, this field configures columns for all
        /// versions. Top-level and per-version columns are mutually exclusive.
        /// If no top-level or per-version columns are specified, a single
        /// column displaying the age of the custom resource is used.</param>
        /// <param name="conversion">conversion defines conversion settings for
        /// the CRD.</param>
        /// <param name="preserveUnknownFields">preserveUnknownFields indicates
        /// that object fields which are not specified in the OpenAPI schema
        /// should be preserved when persisting to storage. apiVersion, kind,
        /// metadata and known fields inside metadata are always preserved. If
        /// false, schemas must be defined for all versions. Defaults to true
        /// in v1beta for backwards compatibility. Deprecated: will be required
        /// to be false in v1. Preservation of unknown fields can be specified
        /// in the validation schema using the
        /// `x-kubernetes-preserve-unknown-fields: true` extension. See
        /// https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/#pruning-versus-preserving-unknown-fields
        /// for details.</param>
        /// <param name="subresources">subresources specify what subresources
        /// the defined custom resource has. If present, this field configures
        /// subresources for all versions. Top-level and per-version
        /// subresources are mutually exclusive.</param>
        /// <param name="validation">validation describes the schema used for
        /// validation and pruning of the custom resource. If present, this
        /// validation schema is used to validate all versions. Top-level and
        /// per-version schemas are mutually exclusive.</param>
        /// <param name="version">version is the API version of the defined
        /// custom resource. The custom resources are served under
        /// `/apis/&lt;group&gt;/&lt;version&gt;/...`. Must match the name of
        /// the first item in the `versions` list if `version` and `versions`
        /// are both specified. Optional if `versions` is specified.
        /// Deprecated: use `versions` instead.</param>
        /// <param name="versions">versions is the list of all API versions of
        /// the defined custom resource. Optional if `version` is specified.
        /// The name of the first item in the `versions` list must match the
        /// `version` field if `version` and `versions` are both specified.
        /// Version names are used to compute the order in which served
        /// versions are listed in API discovery. If the version string is
        /// "kube-like", it will sort above non "kube-like" version strings,
        /// which are ordered lexicographically. "Kube-like" versions start
        /// with a "v", then are followed by a number (the major version), then
        /// optionally the string "alpha" or "beta" and another number (the
        /// minor version). These are sorted first by GA &gt; beta &gt; alpha
        /// (where GA is a version with no suffix such as beta or alpha), and
        /// then by comparing major version, then minor version. An example
        /// sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1,
        /// v12alpha1, v11alpha2, foo1, foo10.</param>
        public V1beta1CustomResourceDefinitionSpec(string group, V1beta1CustomResourceDefinitionNames names, string scope, IList<V1beta1CustomResourceColumnDefinition> additionalPrinterColumns = default(IList<V1beta1CustomResourceColumnDefinition>), V1beta1CustomResourceConversion conversion = default(V1beta1CustomResourceConversion), bool? preserveUnknownFields = default(bool?), V1beta1CustomResourceSubresources subresources = default(V1beta1CustomResourceSubresources), V1beta1CustomResourceValidation validation = default(V1beta1CustomResourceValidation), string version = default(string), IList<V1beta1CustomResourceDefinitionVersion> versions = default(IList<V1beta1CustomResourceDefinitionVersion>))
        {
            AdditionalPrinterColumns = additionalPrinterColumns;
            Conversion = conversion;
            Group = group;
            Names = names;
            PreserveUnknownFields = preserveUnknownFields;
            Scope = scope;
            Subresources = subresources;
            Validation = validation;
            Version = version;
            Versions = versions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets additionalPrinterColumns specifies additional columns
        /// returned in Table output. See
        /// https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables
        /// for details. If present, this field configures columns for all
        /// versions. Top-level and per-version columns are mutually exclusive.
        /// If no top-level or per-version columns are specified, a single
        /// column displaying the age of the custom resource is used.
        /// </summary>
        [JsonProperty(PropertyName = "additionalPrinterColumns")]
        public IList<V1beta1CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

        /// <summary>
        /// Gets or sets conversion defines conversion settings for the CRD.
        /// </summary>
        [JsonProperty(PropertyName = "conversion")]
        public V1beta1CustomResourceConversion Conversion { get; set; }

        /// <summary>
        /// Gets or sets group is the API group of the defined custom resource.
        /// The custom resources are served under
        /// `/apis/&amp;lt;group&amp;gt;/...`. Must match the name of the
        /// CustomResourceDefinition (in the form
        /// `&amp;lt;names.plural&amp;gt;.&amp;lt;group&amp;gt;`).
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets names specify the resource and kind names for the
        /// custom resource.
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public V1beta1CustomResourceDefinitionNames Names { get; set; }

        /// <summary>
        /// Gets or sets preserveUnknownFields indicates that object fields
        /// which are not specified in the OpenAPI schema should be preserved
        /// when persisting to storage. apiVersion, kind, metadata and known
        /// fields inside metadata are always preserved. If false, schemas must
        /// be defined for all versions. Defaults to true in v1beta for
        /// backwards compatibility. Deprecated: will be required to be false
        /// in v1. Preservation of unknown fields can be specified in the
        /// validation schema using the `x-kubernetes-preserve-unknown-fields:
        /// true` extension. See
        /// https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions/#pruning-versus-preserving-unknown-fields
        /// for details.
        /// </summary>
        [JsonProperty(PropertyName = "preserveUnknownFields")]
        public bool? PreserveUnknownFields { get; set; }

        /// <summary>
        /// Gets or sets scope indicates whether the defined custom resource is
        /// cluster- or namespace-scoped. Allowed values are `Cluster` and
        /// `Namespaced`. Default is `Namespaced`.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets subresources specify what subresources the defined
        /// custom resource has. If present, this field configures subresources
        /// for all versions. Top-level and per-version subresources are
        /// mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "subresources")]
        public V1beta1CustomResourceSubresources Subresources { get; set; }

        /// <summary>
        /// Gets or sets validation describes the schema used for validation
        /// and pruning of the custom resource. If present, this validation
        /// schema is used to validate all versions. Top-level and per-version
        /// schemas are mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "validation")]
        public V1beta1CustomResourceValidation Validation { get; set; }

        /// <summary>
        /// Gets or sets version is the API version of the defined custom
        /// resource. The custom resources are served under
        /// `/apis/&amp;lt;group&amp;gt;/&amp;lt;version&amp;gt;/...`. Must
        /// match the name of the first item in the `versions` list if
        /// `version` and `versions` are both specified. Optional if `versions`
        /// is specified. Deprecated: use `versions` instead.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets versions is the list of all API versions of the
        /// defined custom resource. Optional if `version` is specified. The
        /// name of the first item in the `versions` list must match the
        /// `version` field if `version` and `versions` are both specified.
        /// Version names are used to compute the order in which served
        /// versions are listed in API discovery. If the version string is
        /// "kube-like", it will sort above non "kube-like" version strings,
        /// which are ordered lexicographically. "Kube-like" versions start
        /// with a "v", then are followed by a number (the major version), then
        /// optionally the string "alpha" or "beta" and another number (the
        /// minor version). These are sorted first by GA &amp;gt; beta &amp;gt;
        /// alpha (where GA is a version with no suffix such as beta or alpha),
        /// and then by comparing major version, then minor version. An example
        /// sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1,
        /// v12alpha1, v11alpha2, foo1, foo10.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<V1beta1CustomResourceDefinitionVersion> Versions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Group == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Group");
            }
            if (Names == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Names");
            }
            if (Scope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scope");
            }
            if (AdditionalPrinterColumns != null)
            {
                foreach (var element in AdditionalPrinterColumns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Conversion != null)
            {
                Conversion.Validate();
            }
            if (Names != null)
            {
                Names.Validate();
            }
            if (Subresources != null)
            {
                Subresources.Validate();
            }
            if (Versions != null)
            {
                foreach (var element1 in Versions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
