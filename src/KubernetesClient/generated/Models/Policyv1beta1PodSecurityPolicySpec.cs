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
    /// PodSecurityPolicySpec defines the policy enforced.
    /// </summary>
    public partial class Policyv1beta1PodSecurityPolicySpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Policyv1beta1PodSecurityPolicySpec class.
        /// </summary>
        public Policyv1beta1PodSecurityPolicySpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Policyv1beta1PodSecurityPolicySpec class.
        /// </summary>
        /// <param name="fsGroup">fsGroup is the strategy that will dictate
        /// what fs group is used by the SecurityContext.</param>
        /// <param name="runAsUser">runAsUser is the strategy that will dictate
        /// the allowable RunAsUser values that may be set.</param>
        /// <param name="seLinux">seLinux is the strategy that will dictate the
        /// allowable labels that may be set.</param>
        /// <param name="supplementalGroups">supplementalGroups is the strategy
        /// that will dictate what supplemental groups are used by the
        /// SecurityContext.</param>
        /// <param name="allowPrivilegeEscalation">allowPrivilegeEscalation
        /// determines if a pod can request to allow privilege escalation. If
        /// unspecified, defaults to true.</param>
        /// <param name="allowedCapabilities">allowedCapabilities is a list of
        /// capabilities that can be requested to add to the container.
        /// Capabilities in this field may be added at the pod author's
        /// discretion. You must not list a capability in both
        /// allowedCapabilities and requiredDropCapabilities.</param>
        /// <param name="allowedFlexVolumes">allowedFlexVolumes is a whitelist
        /// of allowed Flexvolumes.  Empty or nil indicates that all
        /// Flexvolumes may be used.  This parameter is effective only when the
        /// usage of the Flexvolumes is allowed in the "volumes" field.</param>
        /// <param name="allowedHostPaths">allowedHostPaths is a white list of
        /// allowed host paths. Empty indicates that all host paths may be
        /// used.</param>
        /// <param name="allowedProcMountTypes">AllowedProcMountTypes is a
        /// whitelist of allowed ProcMountTypes. Empty or nil indicates that
        /// only the DefaultProcMountType may be used. This requires the
        /// ProcMountType feature flag to be enabled.</param>
        /// <param name="allowedUnsafeSysctls">allowedUnsafeSysctls is a list
        /// of explicitly allowed unsafe sysctls, defaults to none. Each entry
        /// is either a plain sysctl name or ends in "*" in which case it is
        /// considered as a prefix of allowed sysctls. Single * means all
        /// unsafe sysctls are allowed. Kubelet has to whitelist all allowed
        /// unsafe sysctls explicitly to avoid rejection.
        ///
        /// Examples: e.g. "foo/*" allows "foo/bar", "foo/baz", etc. e.g.
        /// "foo.*" allows "foo.bar", "foo.baz", etc.</param>
        /// <param name="defaultAddCapabilities">defaultAddCapabilities is the
        /// default set of capabilities that will be added to the container
        /// unless the pod spec specifically drops the capability.  You may not
        /// list a capability in both defaultAddCapabilities and
        /// requiredDropCapabilities. Capabilities added here are implicitly
        /// allowed, and need not be included in the allowedCapabilities
        /// list.</param>
        /// <param
        /// name="defaultAllowPrivilegeEscalation">defaultAllowPrivilegeEscalation
        /// controls the default setting for whether a process can gain more
        /// privileges than its parent process.</param>
        /// <param name="forbiddenSysctls">forbiddenSysctls is a list of
        /// explicitly forbidden sysctls, defaults to none. Each entry is
        /// either a plain sysctl name or ends in "*" in which case it is
        /// considered as a prefix of forbidden sysctls. Single * means all
        /// sysctls are forbidden.
        ///
        /// Examples: e.g. "foo/*" forbids "foo/bar", "foo/baz", etc. e.g.
        /// "foo.*" forbids "foo.bar", "foo.baz", etc.</param>
        /// <param name="hostIPC">hostIPC determines if the policy allows the
        /// use of HostIPC in the pod spec.</param>
        /// <param name="hostNetwork">hostNetwork determines if the policy
        /// allows the use of HostNetwork in the pod spec.</param>
        /// <param name="hostPID">hostPID determines if the policy allows the
        /// use of HostPID in the pod spec.</param>
        /// <param name="hostPorts">hostPorts determines which host port ranges
        /// are allowed to be exposed.</param>
        /// <param name="privileged">privileged determines if a pod can request
        /// to be run as privileged.</param>
        /// <param name="readOnlyRootFilesystem">readOnlyRootFilesystem when
        /// set to true will force containers to run with a read only root file
        /// system.  If the container specifically requests to run with a
        /// non-read only root file system the PSP should deny the pod. If set
        /// to false the container may run with a read only root file system if
        /// it wishes but it will not be forced to.</param>
        /// <param name="requiredDropCapabilities">requiredDropCapabilities are
        /// the capabilities that will be dropped from the container.  These
        /// are required to be dropped and cannot be added.</param>
        /// <param name="runAsGroup">RunAsGroup is the strategy that will
        /// dictate the allowable RunAsGroup values that may be set. If this
        /// field is omitted, the pod's RunAsGroup can take any value. This
        /// field requires the RunAsGroup feature gate to be enabled.</param>
        /// <param name="volumes">volumes is a white list of allowed volume
        /// plugins. Empty indicates that no volumes may be used. To allow all
        /// volumes you may use '*'.</param>
        public Policyv1beta1PodSecurityPolicySpec(Policyv1beta1FSGroupStrategyOptions fsGroup, Policyv1beta1RunAsUserStrategyOptions runAsUser, Policyv1beta1SELinuxStrategyOptions seLinux, Policyv1beta1SupplementalGroupsStrategyOptions supplementalGroups, bool? allowPrivilegeEscalation = default(bool?), IList<string> allowedCapabilities = default(IList<string>), IList<Policyv1beta1AllowedFlexVolume> allowedFlexVolumes = default(IList<Policyv1beta1AllowedFlexVolume>), IList<Policyv1beta1AllowedHostPath> allowedHostPaths = default(IList<Policyv1beta1AllowedHostPath>), IList<string> allowedProcMountTypes = default(IList<string>), IList<string> allowedUnsafeSysctls = default(IList<string>), IList<string> defaultAddCapabilities = default(IList<string>), bool? defaultAllowPrivilegeEscalation = default(bool?), IList<string> forbiddenSysctls = default(IList<string>), bool? hostIPC = default(bool?), bool? hostNetwork = default(bool?), bool? hostPID = default(bool?), IList<Policyv1beta1HostPortRange> hostPorts = default(IList<Policyv1beta1HostPortRange>), bool? privileged = default(bool?), bool? readOnlyRootFilesystem = default(bool?), IList<string> requiredDropCapabilities = default(IList<string>), Policyv1beta1RunAsGroupStrategyOptions runAsGroup = default(Policyv1beta1RunAsGroupStrategyOptions), IList<string> volumes = default(IList<string>))
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            AllowedCapabilities = allowedCapabilities;
            AllowedFlexVolumes = allowedFlexVolumes;
            AllowedHostPaths = allowedHostPaths;
            AllowedProcMountTypes = allowedProcMountTypes;
            AllowedUnsafeSysctls = allowedUnsafeSysctls;
            DefaultAddCapabilities = defaultAddCapabilities;
            DefaultAllowPrivilegeEscalation = defaultAllowPrivilegeEscalation;
            ForbiddenSysctls = forbiddenSysctls;
            FsGroup = fsGroup;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            HostPorts = hostPorts;
            Privileged = privileged;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RequiredDropCapabilities = requiredDropCapabilities;
            RunAsGroup = runAsGroup;
            RunAsUser = runAsUser;
            SeLinux = seLinux;
            SupplementalGroups = supplementalGroups;
            Volumes = volumes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowPrivilegeEscalation determines if a pod can
        /// request to allow privilege escalation. If unspecified, defaults to
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "allowPrivilegeEscalation")]
        public bool? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Gets or sets allowedCapabilities is a list of capabilities that can
        /// be requested to add to the container. Capabilities in this field
        /// may be added at the pod author's discretion. You must not list a
        /// capability in both allowedCapabilities and
        /// requiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "allowedCapabilities")]
        public IList<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// Gets or sets allowedFlexVolumes is a whitelist of allowed
        /// Flexvolumes.  Empty or nil indicates that all Flexvolumes may be
        /// used.  This parameter is effective only when the usage of the
        /// Flexvolumes is allowed in the "volumes" field.
        /// </summary>
        [JsonProperty(PropertyName = "allowedFlexVolumes")]
        public IList<Policyv1beta1AllowedFlexVolume> AllowedFlexVolumes { get; set; }

        /// <summary>
        /// Gets or sets allowedHostPaths is a white list of allowed host
        /// paths. Empty indicates that all host paths may be used.
        /// </summary>
        [JsonProperty(PropertyName = "allowedHostPaths")]
        public IList<Policyv1beta1AllowedHostPath> AllowedHostPaths { get; set; }

        /// <summary>
        /// Gets or sets allowedProcMountTypes is a whitelist of allowed
        /// ProcMountTypes. Empty or nil indicates that only the
        /// DefaultProcMountType may be used. This requires the ProcMountType
        /// feature flag to be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "allowedProcMountTypes")]
        public IList<string> AllowedProcMountTypes { get; set; }

        /// <summary>
        /// Gets or sets allowedUnsafeSysctls is a list of explicitly allowed
        /// unsafe sysctls, defaults to none. Each entry is either a plain
        /// sysctl name or ends in "*" in which case it is considered as a
        /// prefix of allowed sysctls. Single * means all unsafe sysctls are
        /// allowed. Kubelet has to whitelist all allowed unsafe sysctls
        /// explicitly to avoid rejection.
        ///
        /// Examples: e.g. "foo/*" allows "foo/bar", "foo/baz", etc. e.g.
        /// "foo.*" allows "foo.bar", "foo.baz", etc.
        /// </summary>
        [JsonProperty(PropertyName = "allowedUnsafeSysctls")]
        public IList<string> AllowedUnsafeSysctls { get; set; }

        /// <summary>
        /// Gets or sets defaultAddCapabilities is the default set of
        /// capabilities that will be added to the container unless the pod
        /// spec specifically drops the capability.  You may not list a
        /// capability in both defaultAddCapabilities and
        /// requiredDropCapabilities. Capabilities added here are implicitly
        /// allowed, and need not be included in the allowedCapabilities list.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAddCapabilities")]
        public IList<string> DefaultAddCapabilities { get; set; }

        /// <summary>
        /// Gets or sets defaultAllowPrivilegeEscalation controls the default
        /// setting for whether a process can gain more privileges than its
        /// parent process.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAllowPrivilegeEscalation")]
        public bool? DefaultAllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Gets or sets forbiddenSysctls is a list of explicitly forbidden
        /// sysctls, defaults to none. Each entry is either a plain sysctl name
        /// or ends in "*" in which case it is considered as a prefix of
        /// forbidden sysctls. Single * means all sysctls are forbidden.
        ///
        /// Examples: e.g. "foo/*" forbids "foo/bar", "foo/baz", etc. e.g.
        /// "foo.*" forbids "foo.bar", "foo.baz", etc.
        /// </summary>
        [JsonProperty(PropertyName = "forbiddenSysctls")]
        public IList<string> ForbiddenSysctls { get; set; }

        /// <summary>
        /// Gets or sets fsGroup is the strategy that will dictate what fs
        /// group is used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "fsGroup")]
        public Policyv1beta1FSGroupStrategyOptions FsGroup { get; set; }

        /// <summary>
        /// Gets or sets hostIPC determines if the policy allows the use of
        /// HostIPC in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Gets or sets hostNetwork determines if the policy allows the use of
        /// HostNetwork in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Gets or sets hostPID determines if the policy allows the use of
        /// HostPID in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// Gets or sets hostPorts determines which host port ranges are
        /// allowed to be exposed.
        /// </summary>
        [JsonProperty(PropertyName = "hostPorts")]
        public IList<Policyv1beta1HostPortRange> HostPorts { get; set; }

        /// <summary>
        /// Gets or sets privileged determines if a pod can request to be run
        /// as privileged.
        /// </summary>
        [JsonProperty(PropertyName = "privileged")]
        public bool? Privileged { get; set; }

        /// <summary>
        /// Gets or sets readOnlyRootFilesystem when set to true will force
        /// containers to run with a read only root file system.  If the
        /// container specifically requests to run with a non-read only root
        /// file system the PSP should deny the pod. If set to false the
        /// container may run with a read only root file system if it wishes
        /// but it will not be forced to.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// Gets or sets requiredDropCapabilities are the capabilities that
        /// will be dropped from the container.  These are required to be
        /// dropped and cannot be added.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDropCapabilities")]
        public IList<string> RequiredDropCapabilities { get; set; }

        /// <summary>
        /// Gets or sets runAsGroup is the strategy that will dictate the
        /// allowable RunAsGroup values that may be set. If this field is
        /// omitted, the pod's RunAsGroup can take any value. This field
        /// requires the RunAsGroup feature gate to be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "runAsGroup")]
        public Policyv1beta1RunAsGroupStrategyOptions RunAsGroup { get; set; }

        /// <summary>
        /// Gets or sets runAsUser is the strategy that will dictate the
        /// allowable RunAsUser values that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public Policyv1beta1RunAsUserStrategyOptions RunAsUser { get; set; }

        /// <summary>
        /// Gets or sets seLinux is the strategy that will dictate the
        /// allowable labels that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "seLinux")]
        public Policyv1beta1SELinuxStrategyOptions SeLinux { get; set; }

        /// <summary>
        /// Gets or sets supplementalGroups is the strategy that will dictate
        /// what supplemental groups are used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "supplementalGroups")]
        public Policyv1beta1SupplementalGroupsStrategyOptions SupplementalGroups { get; set; }

        /// <summary>
        /// Gets or sets volumes is a white list of allowed volume plugins.
        /// Empty indicates that no volumes may be used. To allow all volumes
        /// you may use '*'.
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<string> Volumes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FsGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FsGroup");
            }
            if (RunAsUser == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RunAsUser");
            }
            if (SeLinux == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SeLinux");
            }
            if (SupplementalGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SupplementalGroups");
            }
            if (AllowedFlexVolumes != null)
            {
                foreach (var element in AllowedFlexVolumes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (HostPorts != null)
            {
                foreach (var element1 in HostPorts)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (RunAsGroup != null)
            {
                RunAsGroup.Validate();
            }
            if (RunAsUser != null)
            {
                RunAsUser.Validate();
            }
            if (SeLinux != null)
            {
                SeLinux.Validate();
            }
        }
    }
}
