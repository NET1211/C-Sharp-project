// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// An EphemeralContainer is a temporary container that you may add to an existing
        /// Pod for user-initiated activities such as debugging. Ephemeral containers have
        /// no resource or scheduling guarantees, and they will not be restarted when they
        /// exit or when a Pod is removed or restarted. The kubelet may evict a Pod if an
        /// ephemeral container causes the Pod to exceed its resource allocation.
        /// 
        /// To add an ephemeral container, use the ephemeralcontainers subresource of an
        /// existing Pod. Ephemeral containers may not be removed or restarted.
        /// 
        /// This is a beta feature available on clusters that haven&apos;t disabled the
        /// EphemeralContainers feature gate.
    /// </summary>
    public partial class V1EphemeralContainer
    {
        /// <summary>
        /// Initializes a new instance of the V1EphemeralContainer class.
        /// </summary>
        public V1EphemeralContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1EphemeralContainer class.
        /// </summary>
        /// <param name="name">
        /// Name of the ephemeral container specified as a DNS_LABEL. This name must be
        /// unique among all containers, init containers and ephemeral containers.
        /// </param>
        /// <param name="args">
        /// Arguments to the entrypoint. The docker image&apos;s CMD is used if this is not
        /// provided. Variable references $(VAR_NAME) are expanded using the container&apos;s
        /// environment. If a variable cannot be resolved, the reference in the input string
        /// will be unchanged. Double $$ are reduced to a single $, which allows for
        /// escaping the $(VAR_NAME) syntax: i.e. &quot;$$(VAR_NAME)&quot; will produce the string
        /// literal &quot;$(VAR_NAME)&quot;. Escaped references will never be expanded, regardless of
        /// whether the variable exists or not. Cannot be updated. More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </param>
        /// <param name="command">
        /// Entrypoint array. Not executed within a shell. The docker image&apos;s ENTRYPOINT is
        /// used if this is not provided. Variable references $(VAR_NAME) are expanded using
        /// the container&apos;s environment. If a variable cannot be resolved, the reference in
        /// the input string will be unchanged. Double $$ are reduced to a single $, which
        /// allows for escaping the $(VAR_NAME) syntax: i.e. &quot;$$(VAR_NAME)&quot; will produce the
        /// string literal &quot;$(VAR_NAME)&quot;. Escaped references will never be expanded,
        /// regardless of whether the variable exists or not. Cannot be updated. More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </param>
        /// <param name="env">
        /// List of environment variables to set in the container. Cannot be updated.
        /// </param>
        /// <param name="envFrom">
        /// List of sources to populate environment variables in the container. The keys
        /// defined within a source must be a C_IDENTIFIER. All invalid keys will be
        /// reported as an event when the container is starting. When a key exists in
        /// multiple sources, the value associated with the last source will take
        /// precedence. Values defined by an Env with a duplicate key will take precedence.
        /// Cannot be updated.
        /// </param>
        /// <param name="image">
        /// Docker image name. More info:
        /// https://kubernetes.io/docs/concepts/containers/images
        /// </param>
        /// <param name="imagePullPolicy">
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if
        /// :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More
        /// info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// 
        /// Possible enum values:
        /// - `&quot;Always&quot;` means that kubelet always attempts to pull the latest image.
        /// Container will fail If the pull fails.
        /// - `&quot;IfNotPresent&quot;` means that kubelet pulls if the image isn&apos;t present on disk.
        /// Container will fail if the image isn&apos;t present and the pull fails.
        /// - `&quot;Never&quot;` means that kubelet never pulls an image, but only uses a local
        /// image. Container will fail if the image isn&apos;t present
        /// </param>
        /// <param name="lifecycle">
        /// Lifecycle is not allowed for ephemeral containers.
        /// </param>
        /// <param name="livenessProbe">
        /// Probes are not allowed for ephemeral containers.
        /// </param>
        /// <param name="ports">
        /// Ports are not allowed for ephemeral containers.
        /// </param>
        /// <param name="readinessProbe">
        /// Probes are not allowed for ephemeral containers.
        /// </param>
        /// <param name="resources">
        /// Resources are not allowed for ephemeral containers. Ephemeral containers use
        /// spare resources already allocated to the pod.
        /// </param>
        /// <param name="securityContext">
        /// Optional: SecurityContext defines the security options the ephemeral container
        /// should be run with. If set, the fields of SecurityContext override the
        /// equivalent fields of PodSecurityContext.
        /// </param>
        /// <param name="startupProbe">
        /// Probes are not allowed for ephemeral containers.
        /// </param>
        /// <param name="stdin">
        /// Whether this container should allocate a buffer for stdin in the container
        /// runtime. If this is not set, reads from stdin in the container will always
        /// result in EOF. Default is false.
        /// </param>
        /// <param name="stdinOnce">
        /// Whether the container runtime should close the stdin channel after it has been
        /// opened by a single attach. When stdin is true the stdin stream will remain open
        /// across multiple attach sessions. If stdinOnce is set to true, stdin is opened on
        /// container start, is empty until the first client attaches to stdin, and then
        /// remains open and accepts data until the client disconnects, at which time stdin
        /// is closed and remains closed until the container is restarted. If this flag is
        /// false, a container processes that reads from stdin will never receive an EOF.
        /// Default is false
        /// </param>
        /// <param name="targetContainerName">
        /// If set, the name of the container from PodSpec that this ephemeral container
        /// targets. The ephemeral container will be run in the namespaces (IPC, PID, etc)
        /// of this container. If not set then the ephemeral container uses the namespaces
        /// configured in the Pod spec.
        /// 
        /// The container runtime must implement support for this feature. If the runtime
        /// does not support namespace targeting then the result of setting this field is
        /// undefined.
        /// </param>
        /// <param name="terminationMessagePath">
        /// Optional: Path at which the file to which the container&apos;s termination message
        /// will be written is mounted into the container&apos;s filesystem. Message written is
        /// intended to be brief final status, such as an assertion failure message. Will be
        /// truncated by the node if greater than 4096 bytes. The total message length
        /// across all containers will be limited to 12kb. Defaults to /dev/termination-log.
        /// Cannot be updated.
        /// </param>
        /// <param name="terminationMessagePolicy">
        /// Indicate how the termination message should be populated. File will use the
        /// contents of terminationMessagePath to populate the container status message on
        /// both success and failure. FallbackToLogsOnError will use the last chunk of
        /// container log output if the termination message file is empty and the container
        /// exited with an error. The log output is limited to 2048 bytes or 80 lines,
        /// whichever is smaller. Defaults to File. Cannot be updated.
        /// 
        /// Possible enum values:
        /// - `&quot;FallbackToLogsOnError&quot;` will read the most recent contents of the container
        /// logs for the container status message when the container exits with an error and
        /// the terminationMessagePath has no contents.
        /// - `&quot;File&quot;` is the default behavior and will set the container status message to
        /// the contents of the container&apos;s terminationMessagePath when the container exits.
        /// </param>
        /// <param name="tty">
        /// Whether this container should allocate a TTY for itself, also requires &apos;stdin&apos;
        /// to be true. Default is false.
        /// </param>
        /// <param name="volumeDevices">
        /// volumeDevices is the list of block devices to be used by the container.
        /// </param>
        /// <param name="volumeMounts">
        /// Pod volumes to mount into the container&apos;s filesystem. Subpath mounts are not
        /// allowed for ephemeral containers. Cannot be updated.
        /// </param>
        /// <param name="workingDir">
        /// Container&apos;s working directory. If not specified, the container runtime&apos;s default
        /// will be used, which might be configured in the container image. Cannot be
        /// updated.
        /// </param>
        public V1EphemeralContainer(string name, IList<string> args = null, IList<string> command = null, IList<V1EnvVar> env = null, IList<V1EnvFromSource> envFrom = null, string image = null, string imagePullPolicy = null, V1Lifecycle lifecycle = null, V1Probe livenessProbe = null, IList<V1ContainerPort> ports = null, V1Probe readinessProbe = null, V1ResourceRequirements resources = null, V1SecurityContext securityContext = null, V1Probe startupProbe = null, bool? stdin = null, bool? stdinOnce = null, string targetContainerName = null, string terminationMessagePath = null, string terminationMessagePolicy = null, bool? tty = null, IList<V1VolumeDevice> volumeDevices = null, IList<V1VolumeMount> volumeMounts = null, string workingDir = null)
        {
            Args = args;
            Command = command;
            Env = env;
            EnvFrom = envFrom;
            Image = image;
            ImagePullPolicy = imagePullPolicy;
            Lifecycle = lifecycle;
            LivenessProbe = livenessProbe;
            Name = name;
            Ports = ports;
            ReadinessProbe = readinessProbe;
            Resources = resources;
            SecurityContext = securityContext;
            StartupProbe = startupProbe;
            Stdin = stdin;
            StdinOnce = stdinOnce;
            TargetContainerName = targetContainerName;
            TerminationMessagePath = terminationMessagePath;
            TerminationMessagePolicy = terminationMessagePolicy;
            Tty = tty;
            VolumeDevices = volumeDevices;
            VolumeMounts = volumeMounts;
            WorkingDir = workingDir;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Arguments to the entrypoint. The docker image&apos;s CMD is used if this is not
        /// provided. Variable references $(VAR_NAME) are expanded using the container&apos;s
        /// environment. If a variable cannot be resolved, the reference in the input string
        /// will be unchanged. Double $$ are reduced to a single $, which allows for
        /// escaping the $(VAR_NAME) syntax: i.e. &quot;$$(VAR_NAME)&quot; will produce the string
        /// literal &quot;$(VAR_NAME)&quot;. Escaped references will never be expanded, regardless of
        /// whether the variable exists or not. Cannot be updated. More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        [JsonPropertyName("args")]
        public IList<string> Args { get; set; }

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image&apos;s ENTRYPOINT is
        /// used if this is not provided. Variable references $(VAR_NAME) are expanded using
        /// the container&apos;s environment. If a variable cannot be resolved, the reference in
        /// the input string will be unchanged. Double $$ are reduced to a single $, which
        /// allows for escaping the $(VAR_NAME) syntax: i.e. &quot;$$(VAR_NAME)&quot; will produce the
        /// string literal &quot;$(VAR_NAME)&quot;. Escaped references will never be expanded,
        /// regardless of whether the variable exists or not. Cannot be updated. More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        [JsonPropertyName("command")]
        public IList<string> Command { get; set; }

        /// <summary>
        /// List of environment variables to set in the container. Cannot be updated.
        /// </summary>
        [JsonPropertyName("env")]
        public IList<V1EnvVar> Env { get; set; }

        /// <summary>
        /// List of sources to populate environment variables in the container. The keys
        /// defined within a source must be a C_IDENTIFIER. All invalid keys will be
        /// reported as an event when the container is starting. When a key exists in
        /// multiple sources, the value associated with the last source will take
        /// precedence. Values defined by an Env with a duplicate key will take precedence.
        /// Cannot be updated.
        /// </summary>
        [JsonPropertyName("envFrom")]
        public IList<V1EnvFromSource> EnvFrom { get; set; }

        /// <summary>
        /// Docker image name. More info:
        /// https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if
        /// :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More
        /// info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// 
        /// Possible enum values:
        /// - `&quot;Always&quot;` means that kubelet always attempts to pull the latest image.
        /// Container will fail If the pull fails.
        /// - `&quot;IfNotPresent&quot;` means that kubelet pulls if the image isn&apos;t present on disk.
        /// Container will fail if the image isn&apos;t present and the pull fails.
        /// - `&quot;Never&quot;` means that kubelet never pulls an image, but only uses a local
        /// image. Container will fail if the image isn&apos;t present
        /// </summary>
        [JsonPropertyName("imagePullPolicy")]
        public string ImagePullPolicy { get; set; }

        /// <summary>
        /// Lifecycle is not allowed for ephemeral containers.
        /// </summary>
        [JsonPropertyName("lifecycle")]
        public V1Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        [JsonPropertyName("livenessProbe")]
        public V1Probe LivenessProbe { get; set; }

        /// <summary>
        /// Name of the ephemeral container specified as a DNS_LABEL. This name must be
        /// unique among all containers, init containers and ephemeral containers.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Ports are not allowed for ephemeral containers.
        /// </summary>
        [JsonPropertyName("ports")]
        public IList<V1ContainerPort> Ports { get; set; }

        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        [JsonPropertyName("readinessProbe")]
        public V1Probe ReadinessProbe { get; set; }

        /// <summary>
        /// Resources are not allowed for ephemeral containers. Ephemeral containers use
        /// spare resources already allocated to the pod.
        /// </summary>
        [JsonPropertyName("resources")]
        public V1ResourceRequirements Resources { get; set; }

        /// <summary>
        /// Optional: SecurityContext defines the security options the ephemeral container
        /// should be run with. If set, the fields of SecurityContext override the
        /// equivalent fields of PodSecurityContext.
        /// </summary>
        [JsonPropertyName("securityContext")]
        public V1SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        [JsonPropertyName("startupProbe")]
        public V1Probe StartupProbe { get; set; }

        /// <summary>
        /// Whether this container should allocate a buffer for stdin in the container
        /// runtime. If this is not set, reads from stdin in the container will always
        /// result in EOF. Default is false.
        /// </summary>
        [JsonPropertyName("stdin")]
        public bool? Stdin { get; set; }

        /// <summary>
        /// Whether the container runtime should close the stdin channel after it has been
        /// opened by a single attach. When stdin is true the stdin stream will remain open
        /// across multiple attach sessions. If stdinOnce is set to true, stdin is opened on
        /// container start, is empty until the first client attaches to stdin, and then
        /// remains open and accepts data until the client disconnects, at which time stdin
        /// is closed and remains closed until the container is restarted. If this flag is
        /// false, a container processes that reads from stdin will never receive an EOF.
        /// Default is false
        /// </summary>
        [JsonPropertyName("stdinOnce")]
        public bool? StdinOnce { get; set; }

        /// <summary>
        /// If set, the name of the container from PodSpec that this ephemeral container
        /// targets. The ephemeral container will be run in the namespaces (IPC, PID, etc)
        /// of this container. If not set then the ephemeral container uses the namespaces
        /// configured in the Pod spec.
        /// 
        /// The container runtime must implement support for this feature. If the runtime
        /// does not support namespace targeting then the result of setting this field is
        /// undefined.
        /// </summary>
        [JsonPropertyName("targetContainerName")]
        public string TargetContainerName { get; set; }

        /// <summary>
        /// Optional: Path at which the file to which the container&apos;s termination message
        /// will be written is mounted into the container&apos;s filesystem. Message written is
        /// intended to be brief final status, such as an assertion failure message. Will be
        /// truncated by the node if greater than 4096 bytes. The total message length
        /// across all containers will be limited to 12kb. Defaults to /dev/termination-log.
        /// Cannot be updated.
        /// </summary>
        [JsonPropertyName("terminationMessagePath")]
        public string TerminationMessagePath { get; set; }

        /// <summary>
        /// Indicate how the termination message should be populated. File will use the
        /// contents of terminationMessagePath to populate the container status message on
        /// both success and failure. FallbackToLogsOnError will use the last chunk of
        /// container log output if the termination message file is empty and the container
        /// exited with an error. The log output is limited to 2048 bytes or 80 lines,
        /// whichever is smaller. Defaults to File. Cannot be updated.
        /// 
        /// Possible enum values:
        /// - `&quot;FallbackToLogsOnError&quot;` will read the most recent contents of the container
        /// logs for the container status message when the container exits with an error and
        /// the terminationMessagePath has no contents.
        /// - `&quot;File&quot;` is the default behavior and will set the container status message to
        /// the contents of the container&apos;s terminationMessagePath when the container exits.
        /// </summary>
        [JsonPropertyName("terminationMessagePolicy")]
        public string TerminationMessagePolicy { get; set; }

        /// <summary>
        /// Whether this container should allocate a TTY for itself, also requires &apos;stdin&apos;
        /// to be true. Default is false.
        /// </summary>
        [JsonPropertyName("tty")]
        public bool? Tty { get; set; }

        /// <summary>
        /// volumeDevices is the list of block devices to be used by the container.
        /// </summary>
        [JsonPropertyName("volumeDevices")]
        public IList<V1VolumeDevice> VolumeDevices { get; set; }

        /// <summary>
        /// Pod volumes to mount into the container&apos;s filesystem. Subpath mounts are not
        /// allowed for ephemeral containers. Cannot be updated.
        /// </summary>
        [JsonPropertyName("volumeMounts")]
        public IList<V1VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Container&apos;s working directory. If not specified, the container runtime&apos;s default
        /// will be used, which might be configured in the container image. Cannot be
        /// updated.
        /// </summary>
        [JsonPropertyName("workingDir")]
        public string WorkingDir { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Env != null){
                foreach(var obj in Env)
                {
                    obj.Validate();
                }
            }
            if (EnvFrom != null){
                foreach(var obj in EnvFrom)
                {
                    obj.Validate();
                }
            }
            Lifecycle?.Validate();
            LivenessProbe?.Validate();
            if (Ports != null){
                foreach(var obj in Ports)
                {
                    obj.Validate();
                }
            }
            ReadinessProbe?.Validate();
            Resources?.Validate();
            SecurityContext?.Validate();
            StartupProbe?.Validate();
            if (VolumeDevices != null){
                foreach(var obj in VolumeDevices)
                {
                    obj.Validate();
                }
            }
            if (VolumeMounts != null){
                foreach(var obj in VolumeMounts)
                {
                    obj.Validate();
                }
            }
        }
    }
}
