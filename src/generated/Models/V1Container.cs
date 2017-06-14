// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A single application container that you want to run within a pod.
    /// </summary>
    public partial class V1Container
    {
        /// <summary>
        /// Initializes a new instance of the V1Container class.
        /// </summary>
        public V1Container()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Container class.
        /// </summary>
        /// <param name="name">Name of the container specified as a DNS_LABEL.
        /// Each container in a pod must have a unique name (DNS_LABEL). Cannot
        /// be updated.</param>
        /// <param name="args">Arguments to the entrypoint. The docker image's
        /// CMD is used if this is not provided. Variable references
        /// $(VAR_NAME) are expanded using the container's environment. If a
        /// variable cannot be resolved, the reference in the input string will
        /// be unchanged. The $(VAR_NAME) syntax can be escaped with a double
        /// $$, ie: $$(VAR_NAME). Escaped references will never be expanded,
        /// regardless of whether the variable exists or not. Cannot be
        /// updated. More info:
        /// http://kubernetes.io/docs/user-guide/containers#containers-and-commands</param>
        /// <param name="command">Entrypoint array. Not executed within a
        /// shell. The docker image's ENTRYPOINT is used if this is not
        /// provided. Variable references $(VAR_NAME) are expanded using the
        /// container's environment. If a variable cannot be resolved, the
        /// reference in the input string will be unchanged. The $(VAR_NAME)
        /// syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped
        /// references will never be expanded, regardless of whether the
        /// variable exists or not. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/containers#containers-and-commands</param>
        /// <param name="env">List of environment variables to set in the
        /// container. Cannot be updated.</param>
        /// <param name="envFrom">List of sources to populate environment
        /// variables in the container. The keys defined within a source must
        /// be a C_IDENTIFIER. All invalid keys will be reported as an event
        /// when the container is starting. When a key exists in multiple
        /// sources, the value associated with the last source will take
        /// precedence. Values defined by an Env with a duplicate key will take
        /// precedence. Cannot be updated.</param>
        /// <param name="image">Docker image name. More info:
        /// http://kubernetes.io/docs/user-guide/images</param>
        /// <param name="imagePullPolicy">Image pull policy. One of Always,
        /// Never, IfNotPresent. Defaults to Always if :latest tag is
        /// specified, or IfNotPresent otherwise. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/images#updating-images</param>
        /// <param name="lifecycle">Actions that the management system should
        /// take in response to container lifecycle events. Cannot be
        /// updated.</param>
        /// <param name="livenessProbe">Periodic probe of container liveness.
        /// Container will be restarted if the probe fails. Cannot be updated.
        /// More info:
        /// http://kubernetes.io/docs/user-guide/pod-states#container-probes</param>
        /// <param name="ports">List of ports to expose from the container.
        /// Exposing a port here gives the system additional information about
        /// the network connections a container uses, but is primarily
        /// informational. Not specifying a port here DOES NOT prevent that
        /// port from being exposed. Any port which is listening on the default
        /// "0.0.0.0" address inside a container will be accessible from the
        /// network. Cannot be updated.</param>
        /// <param name="readinessProbe">Periodic probe of container service
        /// readiness. Container will be removed from service endpoints if the
        /// probe fails. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/pod-states#container-probes</param>
        /// <param name="resources">Compute Resources required by this
        /// container. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/persistent-volumes#resources</param>
        /// <param name="securityContext">Security options the pod should run
        /// with. More info:
        /// http://releases.k8s.io/HEAD/docs/design/security_context.md</param>
        /// <param name="stdin">Whether this container should allocate a buffer
        /// for stdin in the container runtime. If this is not set, reads from
        /// stdin in the container will always result in EOF. Default is
        /// false.</param>
        /// <param name="stdinOnce">Whether the container runtime should close
        /// the stdin channel after it has been opened by a single attach. When
        /// stdin is true the stdin stream will remain open across multiple
        /// attach sessions. If stdinOnce is set to true, stdin is opened on
        /// container start, is empty until the first client attaches to stdin,
        /// and then remains open and accepts data until the client
        /// disconnects, at which time stdin is closed and remains closed until
        /// the container is restarted. If this flag is false, a container
        /// processes that reads from stdin will never receive an EOF. Default
        /// is false</param>
        /// <param name="terminationMessagePath">Optional: Path at which the
        /// file to which the container's termination message will be written
        /// is mounted into the container's filesystem. Message written is
        /// intended to be brief final status, such as an assertion failure
        /// message. Will be truncated by the node if greater than 4096 bytes.
        /// The total message length across all containers will be limited to
        /// 12kb. Defaults to /dev/termination-log. Cannot be updated.</param>
        /// <param name="terminationMessagePolicy">Indicate how the termination
        /// message should be populated. File will use the contents of
        /// terminationMessagePath to populate the container status message on
        /// both success and failure. FallbackToLogsOnError will use the last
        /// chunk of container log output if the termination message file is
        /// empty and the container exited with an error. The log output is
        /// limited to 2048 bytes or 80 lines, whichever is smaller. Defaults
        /// to File. Cannot be updated.</param>
        /// <param name="tty">Whether this container should allocate a TTY for
        /// itself, also requires 'stdin' to be true. Default is false.</param>
        /// <param name="volumeMounts">Pod volumes to mount into the
        /// container's filesystem. Cannot be updated.</param>
        /// <param name="workingDir">Container's working directory. If not
        /// specified, the container runtime's default will be used, which
        /// might be configured in the container image. Cannot be
        /// updated.</param>
        public V1Container(string name, IList<string> args = default(IList<string>), IList<string> command = default(IList<string>), IList<V1EnvVar> env = default(IList<V1EnvVar>), IList<V1EnvFromSource> envFrom = default(IList<V1EnvFromSource>), string image = default(string), string imagePullPolicy = default(string), V1Lifecycle lifecycle = default(V1Lifecycle), V1Probe livenessProbe = default(V1Probe), IList<V1ContainerPort> ports = default(IList<V1ContainerPort>), V1Probe readinessProbe = default(V1Probe), V1ResourceRequirements resources = default(V1ResourceRequirements), V1SecurityContext securityContext = default(V1SecurityContext), bool? stdin = default(bool?), bool? stdinOnce = default(bool?), string terminationMessagePath = default(string), string terminationMessagePolicy = default(string), bool? tty = default(bool?), IList<V1VolumeMount> volumeMounts = default(IList<V1VolumeMount>), string workingDir = default(string))
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
            Stdin = stdin;
            StdinOnce = stdinOnce;
            TerminationMessagePath = terminationMessagePath;
            TerminationMessagePolicy = terminationMessagePolicy;
            Tty = tty;
            VolumeMounts = volumeMounts;
            WorkingDir = workingDir;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets arguments to the entrypoint. The docker image's CMD is
        /// used if this is not provided. Variable references $(VAR_NAME) are
        /// expanded using the container's environment. If a variable cannot be
        /// resolved, the reference in the input string will be unchanged. The
        /// $(VAR_NAME) syntax can be escaped with a double $$, ie:
        /// $$(VAR_NAME). Escaped references will never be expanded, regardless
        /// of whether the variable exists or not. Cannot be updated. More
        /// info:
        /// http://kubernetes.io/docs/user-guide/containers#containers-and-commands
        /// </summary>
        [JsonProperty(PropertyName = "args")]
        public IList<string> Args { get; set; }

        /// <summary>
        /// Gets or sets entrypoint array. Not executed within a shell. The
        /// docker image's ENTRYPOINT is used if this is not provided. Variable
        /// references $(VAR_NAME) are expanded using the container's
        /// environment. If a variable cannot be resolved, the reference in the
        /// input string will be unchanged. The $(VAR_NAME) syntax can be
        /// escaped with a double $$, ie: $$(VAR_NAME). Escaped references will
        /// never be expanded, regardless of whether the variable exists or
        /// not. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/containers#containers-and-commands
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public IList<string> Command { get; set; }

        /// <summary>
        /// Gets or sets list of environment variables to set in the container.
        /// Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "env")]
        public IList<V1EnvVar> Env { get; set; }

        /// <summary>
        /// Gets or sets list of sources to populate environment variables in
        /// the container. The keys defined within a source must be a
        /// C_IDENTIFIER. All invalid keys will be reported as an event when
        /// the container is starting. When a key exists in multiple sources,
        /// the value associated with the last source will take precedence.
        /// Values defined by an Env with a duplicate key will take precedence.
        /// Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "envFrom")]
        public IList<V1EnvFromSource> EnvFrom { get; set; }

        /// <summary>
        /// Gets or sets docker image name. More info:
        /// http://kubernetes.io/docs/user-guide/images
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets image pull policy. One of Always, Never, IfNotPresent.
        /// Defaults to Always if :latest tag is specified, or IfNotPresent
        /// otherwise. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/images#updating-images
        /// </summary>
        [JsonProperty(PropertyName = "imagePullPolicy")]
        public string ImagePullPolicy { get; set; }

        /// <summary>
        /// Gets or sets actions that the management system should take in
        /// response to container lifecycle events. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "lifecycle")]
        public V1Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// Gets or sets periodic probe of container liveness. Container will
        /// be restarted if the probe fails. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/pod-states#container-probes
        /// </summary>
        [JsonProperty(PropertyName = "livenessProbe")]
        public V1Probe LivenessProbe { get; set; }

        /// <summary>
        /// Gets or sets name of the container specified as a DNS_LABEL. Each
        /// container in a pod must have a unique name (DNS_LABEL). Cannot be
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of ports to expose from the container. Exposing a
        /// port here gives the system additional information about the network
        /// connections a container uses, but is primarily informational. Not
        /// specifying a port here DOES NOT prevent that port from being
        /// exposed. Any port which is listening on the default "0.0.0.0"
        /// address inside a container will be accessible from the network.
        /// Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<V1ContainerPort> Ports { get; set; }

        /// <summary>
        /// Gets or sets periodic probe of container service readiness.
        /// Container will be removed from service endpoints if the probe
        /// fails. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/pod-states#container-probes
        /// </summary>
        [JsonProperty(PropertyName = "readinessProbe")]
        public V1Probe ReadinessProbe { get; set; }

        /// <summary>
        /// Gets or sets compute Resources required by this container. Cannot
        /// be updated. More info:
        /// http://kubernetes.io/docs/user-guide/persistent-volumes#resources
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public V1ResourceRequirements Resources { get; set; }

        /// <summary>
        /// Gets or sets security options the pod should run with. More info:
        /// http://releases.k8s.io/HEAD/docs/design/security_context.md
        /// </summary>
        [JsonProperty(PropertyName = "securityContext")]
        public V1SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Gets or sets whether this container should allocate a buffer for
        /// stdin in the container runtime. If this is not set, reads from
        /// stdin in the container will always result in EOF. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "stdin")]
        public bool? Stdin { get; set; }

        /// <summary>
        /// Gets or sets whether the container runtime should close the stdin
        /// channel after it has been opened by a single attach. When stdin is
        /// true the stdin stream will remain open across multiple attach
        /// sessions. If stdinOnce is set to true, stdin is opened on container
        /// start, is empty until the first client attaches to stdin, and then
        /// remains open and accepts data until the client disconnects, at
        /// which time stdin is closed and remains closed until the container
        /// is restarted. If this flag is false, a container processes that
        /// reads from stdin will never receive an EOF. Default is false
        /// </summary>
        [JsonProperty(PropertyName = "stdinOnce")]
        public bool? StdinOnce { get; set; }

        /// <summary>
        /// Gets or sets optional: Path at which the file to which the
        /// container's termination message will be written is mounted into the
        /// container's filesystem. Message written is intended to be brief
        /// final status, such as an assertion failure message. Will be
        /// truncated by the node if greater than 4096 bytes. The total message
        /// length across all containers will be limited to 12kb. Defaults to
        /// /dev/termination-log. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "terminationMessagePath")]
        public string TerminationMessagePath { get; set; }

        /// <summary>
        /// Gets or sets indicate how the termination message should be
        /// populated. File will use the contents of terminationMessagePath to
        /// populate the container status message on both success and failure.
        /// FallbackToLogsOnError will use the last chunk of container log
        /// output if the termination message file is empty and the container
        /// exited with an error. The log output is limited to 2048 bytes or 80
        /// lines, whichever is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "terminationMessagePolicy")]
        public string TerminationMessagePolicy { get; set; }

        /// <summary>
        /// Gets or sets whether this container should allocate a TTY for
        /// itself, also requires 'stdin' to be true. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "tty")]
        public bool? Tty { get; set; }

        /// <summary>
        /// Gets or sets pod volumes to mount into the container's filesystem.
        /// Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "volumeMounts")]
        public IList<V1VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Gets or sets container's working directory. If not specified, the
        /// container runtime's default will be used, which might be configured
        /// in the container image. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "workingDir")]
        public string WorkingDir { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Env != null)
            {
                foreach (var element in Env)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Lifecycle != null)
            {
                Lifecycle.Validate();
            }
            if (LivenessProbe != null)
            {
                LivenessProbe.Validate();
            }
            if (Ports != null)
            {
                foreach (var element1 in Ports)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (ReadinessProbe != null)
            {
                ReadinessProbe.Validate();
            }
            if (VolumeMounts != null)
            {
                foreach (var element2 in VolumeMounts)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
