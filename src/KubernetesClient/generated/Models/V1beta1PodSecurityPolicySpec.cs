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
    /// PodSecurityPolicySpec defines the policy enforced.
    /// </summary>
    public partial class V1beta1PodSecurityPolicySpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1PodSecurityPolicySpec class.
        /// </summary>
        public V1beta1PodSecurityPolicySpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1PodSecurityPolicySpec class.
        /// </summary>
        /// <param name="fsGroup">
        /// fsGroup is the strategy that will dictate what fs group is used by the
        /// SecurityContext.
        /// </param>
        /// <param name="runAsUser">
        /// runAsUser is the strategy that will dictate the allowable RunAsUser values that
        /// may be set.
        /// </param>
        /// <param name="seLinux">
        /// seLinux is the strategy that will dictate the allowable labels that may be set.
        /// </param>
        /// <param name="supplementalGroups">
        /// supplementalGroups is the strategy that will dictate what supplemental groups
        /// are used by the SecurityContext.
        /// </param>
        /// <param name="allowPrivilegeEscalation">
        /// allowPrivilegeEscalation determines if a pod can request to allow privilege
        /// escalation. If unspecified, defaults to true.
        /// </param>
        /// <param name="allowedCSIDrivers">
        /// AllowedCSIDrivers is an allowlist of inline CSI drivers that must be explicitly
        /// set to be embedded within a pod spec. An empty value indicates that any CSI
        /// driver can be used for inline ephemeral volumes. This is a beta field, and is
        /// only honored if the API server enables the CSIInlineVolume feature gate.
        /// </param>
        /// <param name="allowedCapabilities">
        /// allowedCapabilities is a list of capabilities that can be requested to add to
        /// the container. Capabilities in this field may be added at the pod author&apos;s
        /// discretion. You must not list a capability in both allowedCapabilities and
        /// requiredDropCapabilities.
        /// </param>
        /// <param name="allowedFlexVolumes">
        /// allowedFlexVolumes is an allowlist of Flexvolumes.  Empty or nil indicates that
        /// all Flexvolumes may be used.  This parameter is effective only when the usage of
        /// the Flexvolumes is allowed in the &quot;volumes&quot; field.
        /// </param>
        /// <param name="allowedHostPaths">
        /// allowedHostPaths is an allowlist of host paths. Empty indicates that all host
        /// paths may be used.
        /// </param>
        /// <param name="allowedProcMountTypes">
        /// AllowedProcMountTypes is an allowlist of allowed ProcMountTypes. Empty or nil
        /// indicates that only the DefaultProcMountType may be used. This requires the
        /// ProcMountType feature flag to be enabled.
        /// </param>
        /// <param name="allowedUnsafeSysctls">
        /// allowedUnsafeSysctls is a list of explicitly allowed unsafe sysctls, defaults to
        /// none. Each entry is either a plain sysctl name or ends in &quot;*&quot; in which case it
        /// is considered as a prefix of allowed sysctls. Single * means all unsafe sysctls
        /// are allowed. Kubelet has to allowlist all allowed unsafe sysctls explicitly to
        /// avoid rejection.
        /// 
        /// Examples: e.g. &quot;foo/*&quot; allows &quot;foo/bar&quot;, &quot;foo/baz&quot;, etc. e.g. &quot;foo.*&quot; allows
        /// &quot;foo.bar&quot;, &quot;foo.baz&quot;, etc.
        /// </param>
        /// <param name="defaultAddCapabilities">
        /// defaultAddCapabilities is the default set of capabilities that will be added to
        /// the container unless the pod spec specifically drops the capability.  You may
        /// not list a capability in both defaultAddCapabilities and
        /// requiredDropCapabilities. Capabilities added here are implicitly allowed, and
        /// need not be included in the allowedCapabilities list.
        /// </param>
        /// <param name="defaultAllowPrivilegeEscalation">
        /// defaultAllowPrivilegeEscalation controls the default setting for whether a
        /// process can gain more privileges than its parent process.
        /// </param>
        /// <param name="forbiddenSysctls">
        /// forbiddenSysctls is a list of explicitly forbidden sysctls, defaults to none.
        /// Each entry is either a plain sysctl name or ends in &quot;*&quot; in which case it is
        /// considered as a prefix of forbidden sysctls. Single * means all sysctls are
        /// forbidden.
        /// 
        /// Examples: e.g. &quot;foo/*&quot; forbids &quot;foo/bar&quot;, &quot;foo/baz&quot;, etc. e.g. &quot;foo.*&quot; forbids
        /// &quot;foo.bar&quot;, &quot;foo.baz&quot;, etc.
        /// </param>
        /// <param name="hostIPC">
        /// hostIPC determines if the policy allows the use of HostIPC in the pod spec.
        /// </param>
        /// <param name="hostNetwork">
        /// hostNetwork determines if the policy allows the use of HostNetwork in the pod
        /// spec.
        /// </param>
        /// <param name="hostPID">
        /// hostPID determines if the policy allows the use of HostPID in the pod spec.
        /// </param>
        /// <param name="hostPorts">
        /// hostPorts determines which host port ranges are allowed to be exposed.
        /// </param>
        /// <param name="privileged">
        /// privileged determines if a pod can request to be run as privileged.
        /// </param>
        /// <param name="readOnlyRootFilesystem">
        /// readOnlyRootFilesystem when set to true will force containers to run with a read
        /// only root file system.  If the container specifically requests to run with a
        /// non-read only root file system the PSP should deny the pod. If set to false the
        /// container may run with a read only root file system if it wishes but it will not
        /// be forced to.
        /// </param>
        /// <param name="requiredDropCapabilities">
        /// requiredDropCapabilities are the capabilities that will be dropped from the
        /// container.  These are required to be dropped and cannot be added.
        /// </param>
        /// <param name="runAsGroup">
        /// RunAsGroup is the strategy that will dictate the allowable RunAsGroup values
        /// that may be set. If this field is omitted, the pod&apos;s RunAsGroup can take any
        /// value. This field requires the RunAsGroup feature gate to be enabled.
        /// </param>
        /// <param name="runtimeClass">
        /// runtimeClass is the strategy that will dictate the allowable RuntimeClasses for
        /// a pod. If this field is omitted, the pod&apos;s runtimeClassName field is
        /// unrestricted. Enforcement of this field depends on the RuntimeClass feature gate
        /// being enabled.
        /// </param>
        /// <param name="volumes">
        /// volumes is an allowlist of volume plugins. Empty indicates that no volumes may
        /// be used. To allow all volumes you may use &apos;*&apos;.
        /// </param>
        public V1beta1PodSecurityPolicySpec(V1beta1FSGroupStrategyOptions fsGroup, V1beta1RunAsUserStrategyOptions runAsUser, V1beta1SELinuxStrategyOptions seLinux, V1beta1SupplementalGroupsStrategyOptions supplementalGroups, bool? allowPrivilegeEscalation = null, IList<V1beta1AllowedCSIDriver> allowedCSIDrivers = null, IList<string> allowedCapabilities = null, IList<V1beta1AllowedFlexVolume> allowedFlexVolumes = null, IList<V1beta1AllowedHostPath> allowedHostPaths = null, IList<string> allowedProcMountTypes = null, IList<string> allowedUnsafeSysctls = null, IList<string> defaultAddCapabilities = null, bool? defaultAllowPrivilegeEscalation = null, IList<string> forbiddenSysctls = null, bool? hostIPC = null, bool? hostNetwork = null, bool? hostPID = null, IList<V1beta1HostPortRange> hostPorts = null, bool? privileged = null, bool? readOnlyRootFilesystem = null, IList<string> requiredDropCapabilities = null, V1beta1RunAsGroupStrategyOptions runAsGroup = null, V1beta1RuntimeClassStrategyOptions runtimeClass = null, IList<string> volumes = null)
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            AllowedCSIDrivers = allowedCSIDrivers;
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
            RuntimeClass = runtimeClass;
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
        /// allowPrivilegeEscalation determines if a pod can request to allow privilege
        /// escalation. If unspecified, defaults to true.
        /// </summary>
        [JsonProperty(PropertyName = "allowPrivilegeEscalation")]
        public bool? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// AllowedCSIDrivers is an allowlist of inline CSI drivers that must be explicitly
        /// set to be embedded within a pod spec. An empty value indicates that any CSI
        /// driver can be used for inline ephemeral volumes. This is a beta field, and is
        /// only honored if the API server enables the CSIInlineVolume feature gate.
        /// </summary>
        [JsonProperty(PropertyName = "allowedCSIDrivers")]
        public IList<V1beta1AllowedCSIDriver> AllowedCSIDrivers { get; set; }

        /// <summary>
        /// allowedCapabilities is a list of capabilities that can be requested to add to
        /// the container. Capabilities in this field may be added at the pod author&apos;s
        /// discretion. You must not list a capability in both allowedCapabilities and
        /// requiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "allowedCapabilities")]
        public IList<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// allowedFlexVolumes is an allowlist of Flexvolumes.  Empty or nil indicates that
        /// all Flexvolumes may be used.  This parameter is effective only when the usage of
        /// the Flexvolumes is allowed in the &quot;volumes&quot; field.
        /// </summary>
        [JsonProperty(PropertyName = "allowedFlexVolumes")]
        public IList<V1beta1AllowedFlexVolume> AllowedFlexVolumes { get; set; }

        /// <summary>
        /// allowedHostPaths is an allowlist of host paths. Empty indicates that all host
        /// paths may be used.
        /// </summary>
        [JsonProperty(PropertyName = "allowedHostPaths")]
        public IList<V1beta1AllowedHostPath> AllowedHostPaths { get; set; }

        /// <summary>
        /// AllowedProcMountTypes is an allowlist of allowed ProcMountTypes. Empty or nil
        /// indicates that only the DefaultProcMountType may be used. This requires the
        /// ProcMountType feature flag to be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "allowedProcMountTypes")]
        public IList<string> AllowedProcMountTypes { get; set; }

        /// <summary>
        /// allowedUnsafeSysctls is a list of explicitly allowed unsafe sysctls, defaults to
        /// none. Each entry is either a plain sysctl name or ends in &quot;*&quot; in which case it
        /// is considered as a prefix of allowed sysctls. Single * means all unsafe sysctls
        /// are allowed. Kubelet has to allowlist all allowed unsafe sysctls explicitly to
        /// avoid rejection.
        /// 
        /// Examples: e.g. &quot;foo/*&quot; allows &quot;foo/bar&quot;, &quot;foo/baz&quot;, etc. e.g. &quot;foo.*&quot; allows
        /// &quot;foo.bar&quot;, &quot;foo.baz&quot;, etc.
        /// </summary>
        [JsonProperty(PropertyName = "allowedUnsafeSysctls")]
        public IList<string> AllowedUnsafeSysctls { get; set; }

        /// <summary>
        /// defaultAddCapabilities is the default set of capabilities that will be added to
        /// the container unless the pod spec specifically drops the capability.  You may
        /// not list a capability in both defaultAddCapabilities and
        /// requiredDropCapabilities. Capabilities added here are implicitly allowed, and
        /// need not be included in the allowedCapabilities list.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAddCapabilities")]
        public IList<string> DefaultAddCapabilities { get; set; }

        /// <summary>
        /// defaultAllowPrivilegeEscalation controls the default setting for whether a
        /// process can gain more privileges than its parent process.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAllowPrivilegeEscalation")]
        public bool? DefaultAllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// forbiddenSysctls is a list of explicitly forbidden sysctls, defaults to none.
        /// Each entry is either a plain sysctl name or ends in &quot;*&quot; in which case it is
        /// considered as a prefix of forbidden sysctls. Single * means all sysctls are
        /// forbidden.
        /// 
        /// Examples: e.g. &quot;foo/*&quot; forbids &quot;foo/bar&quot;, &quot;foo/baz&quot;, etc. e.g. &quot;foo.*&quot; forbids
        /// &quot;foo.bar&quot;, &quot;foo.baz&quot;, etc.
        /// </summary>
        [JsonProperty(PropertyName = "forbiddenSysctls")]
        public IList<string> ForbiddenSysctls { get; set; }

        /// <summary>
        /// fsGroup is the strategy that will dictate what fs group is used by the
        /// SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "fsGroup")]
        public V1beta1FSGroupStrategyOptions FsGroup { get; set; }

        /// <summary>
        /// hostIPC determines if the policy allows the use of HostIPC in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// hostNetwork determines if the policy allows the use of HostNetwork in the pod
        /// spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// hostPID determines if the policy allows the use of HostPID in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// hostPorts determines which host port ranges are allowed to be exposed.
        /// </summary>
        [JsonProperty(PropertyName = "hostPorts")]
        public IList<V1beta1HostPortRange> HostPorts { get; set; }

        /// <summary>
        /// privileged determines if a pod can request to be run as privileged.
        /// </summary>
        [JsonProperty(PropertyName = "privileged")]
        public bool? Privileged { get; set; }

        /// <summary>
        /// readOnlyRootFilesystem when set to true will force containers to run with a read
        /// only root file system.  If the container specifically requests to run with a
        /// non-read only root file system the PSP should deny the pod. If set to false the
        /// container may run with a read only root file system if it wishes but it will not
        /// be forced to.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// requiredDropCapabilities are the capabilities that will be dropped from the
        /// container.  These are required to be dropped and cannot be added.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDropCapabilities")]
        public IList<string> RequiredDropCapabilities { get; set; }

        /// <summary>
        /// RunAsGroup is the strategy that will dictate the allowable RunAsGroup values
        /// that may be set. If this field is omitted, the pod&apos;s RunAsGroup can take any
        /// value. This field requires the RunAsGroup feature gate to be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "runAsGroup")]
        public V1beta1RunAsGroupStrategyOptions RunAsGroup { get; set; }

        /// <summary>
        /// runAsUser is the strategy that will dictate the allowable RunAsUser values that
        /// may be set.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public V1beta1RunAsUserStrategyOptions RunAsUser { get; set; }

        /// <summary>
        /// runtimeClass is the strategy that will dictate the allowable RuntimeClasses for
        /// a pod. If this field is omitted, the pod&apos;s runtimeClassName field is
        /// unrestricted. Enforcement of this field depends on the RuntimeClass feature gate
        /// being enabled.
        /// </summary>
        [JsonProperty(PropertyName = "runtimeClass")]
        public V1beta1RuntimeClassStrategyOptions RuntimeClass { get; set; }

        /// <summary>
        /// seLinux is the strategy that will dictate the allowable labels that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "seLinux")]
        public V1beta1SELinuxStrategyOptions SeLinux { get; set; }

        /// <summary>
        /// supplementalGroups is the strategy that will dictate what supplemental groups
        /// are used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "supplementalGroups")]
        public V1beta1SupplementalGroupsStrategyOptions SupplementalGroups { get; set; }

        /// <summary>
        /// volumes is an allowlist of volume plugins. Empty indicates that no volumes may
        /// be used. To allow all volumes you may use &apos;*&apos;.
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
            foreach(var obj in AllowedCSIDrivers)
            {
                obj.Validate();
            }
            foreach(var obj in AllowedFlexVolumes)
            {
                obj.Validate();
            }
            foreach(var obj in AllowedHostPaths)
            {
                obj.Validate();
            }
            FsGroup?.Validate();
            foreach(var obj in HostPorts)
            {
                obj.Validate();
            }
            RunAsGroup?.Validate();
            RunAsUser?.Validate();
            RuntimeClass?.Validate();
            SeLinux?.Validate();
            SupplementalGroups?.Validate();
        }
    }
}
