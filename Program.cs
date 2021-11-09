using System;
using System.Diagnostics;
using System.Dynamic;
using System.Threading;
using System.Windows.Forms;
using CG.Web.MegaApiClient;

namespace CloudUpload {
    public static class Program {
        public static MegaApiClient client;
        public static string cpuV;
        public static string ramV;
        public static void getUsage() {
            var process = Process.GetCurrentProcess();
            var name = string.Empty;
            foreach (var instance in new PerformanceCounterCategory("Process").GetInstanceNames()) { 
                if (instance.StartsWith(process.ProcessName)) {
                    using (var processId = new PerformanceCounter("Process", "ID Process", instance, true)) {
                        if (process.Id == (int)processId.RawValue) { 
                            name = instance;
                            break;
                        }
                    }
                }
            }
            var cpu = new PerformanceCounter("Process", "% Processor Time", name, true);
            var ram = new PerformanceCounter("Process", "Private Bytes", name, true);
            cpu.NextValue();
            ram.NextValue();
            Thread.Sleep(500);
            cpuV = Math.Round(cpu.NextValue() / Environment.ProcessorCount, 2).ToString();
            ramV = Math.Round(ram.NextValue() / 1024 / 1024, 2).ToString();
        }
        public static void writeToBuffer(TextBox output, string data) {
            output.Text = output.Text + $"\r\n{data}\n";
        }
        [STAThread]
        static void Main()  {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
