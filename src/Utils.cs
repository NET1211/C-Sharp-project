﻿namespace k8s
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    public static class Utils
    {
        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Decode(string text)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }

        /// <summary>
        /// Generates pfx from client configuration
        /// </summary>
        /// <param name="config">Kuberentes Client Configuration</param>
        /// <returns>Generated Pfx Path</returns>
        /// TODO: kabhishek8260 Remplace the method with X509 Certificate with private key(in dotnet 2.0)
        public static async Task<string> GeneratePfxAsync(KubernetesClientConfiguration config)
        {
            var userHomeDir = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
                Environment.GetEnvironmentVariable("USERPROFILE") :
                Environment.GetEnvironmentVariable("HOME");

            var certDirPath = Path.Combine(userHomeDir, ".k8scerts");
            Directory.CreateDirectory(certDirPath);

            var filePrefix = config.CurrentContext;
            var keyFilePath = Path.Combine(certDirPath, filePrefix + "key");
            var certFilePath = Path.Combine(certDirPath, filePrefix + "cert");
            var pfxFilePath = Path.Combine(certDirPath, filePrefix + "pfx");

            using (FileStream fs = File.Create(keyFilePath))
            {
                byte[] info = Convert.FromBase64String(config.ClientCertificateKey);
                await fs.WriteAsync(info, 0, info.Length).ConfigureAwait(false);
            }

            using (FileStream fs = File.Create(certFilePath))
            {
                byte[] info = Convert.FromBase64String(config.ClientCertificateData);
                await fs.WriteAsync(info, 0, info.Length).ConfigureAwait(false);
            }

            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = @"openssl",
                Arguments = $"pkcs12 -export -out {pfxFilePath} -inkey {keyFilePath} -in {certFilePath} -passout pass:",
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };

            process.Start();
            process.WaitForExit();
            if (process.ExitCode == 0)
            {
                return pfxFilePath;
            }

            return null;
        }
    }
}
