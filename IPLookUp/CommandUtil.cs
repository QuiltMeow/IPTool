using System;
using System.Diagnostics;
using System.IO;

namespace IPLookUp
{
    public static class CommandUtil
    {
        public const string EMPTY_STRING = "";

        public static string runCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = "cmd.exe",
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            using (Process process = new Process()
            {
                StartInfo = startInfo
            })
            {
                try
                {
                    process.Start();
                    StreamWriter input = process.StandardInput;
                    input.WriteLine(command);
                    input.WriteLine("exit");

                    string ret = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return ret;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static void runProcess(string target, string argument = EMPTY_STRING, DataReceivedEventHandler handler = null)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                Arguments = argument,
                CreateNoWindow = true,
                FileName = target,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            using (Process process = new Process()
            {
                StartInfo = startInfo
            })
            {
                if (handler != null)
                {
                    process.EnableRaisingEvents = true;
                    process.OutputDataReceived += handler;
                }

                try
                {
                    process.Start();
                    process.BeginOutputReadLine();
                    process.WaitForExit();
                }
                catch
                {
                }
                finally
                {
                    try
                    {
                        process.CancelOutputRead();
                    }
                    catch
                    {
                    }
                }
            }
        }

        public static void ping(string host, DataReceivedEventHandler handler)
        {
            runProcess("ping.exe", $"\"{host}\"", handler);
        }

        public static void traceRouter(string host, DataReceivedEventHandler handler)
        {
            runProcess("tracert.exe", $"\"{host}\"", handler);
        }
    }
}