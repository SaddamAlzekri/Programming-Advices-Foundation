using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    // فتح Process
    [DllImport("kernel32.dll")]
    static extern IntPtr OpenProcess(
        uint processAccess,
        bool bInheritHandle,
        int processId);

    // إغلاق Handle
    [DllImport("kernel32.dll")]
    static extern bool CloseHandle(IntPtr hObject);

    // جلب معلومات الذاكرة
    [DllImport("psapi.dll", SetLastError = true)]
    static extern bool GetProcessMemoryInfo(
        IntPtr hProcess,
        out PROCESS_MEMORY_COUNTERS counters,
        uint size);

    // صلاحيات القراءة
    const uint PROCESS_QUERY_INFORMATION = 0x0400;
    const uint PROCESS_VM_READ = 0x0010;

    // Struct معلومات الذاكرة
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_MEMORY_COUNTERS
    {
        public uint cb;
        public uint PageFaultCount;
        public ulong PeakWorkingSetSize;
        public ulong WorkingSetSize;
        public ulong QuotaPeakPagedPoolUsage;
        public ulong QuotaPagedPoolUsage;
        public ulong QuotaPeakNonPagedPoolUsage;
        public ulong QuotaNonPagedPoolUsage;
        public ulong PagefileUsage;
        public ulong PeakPagefileUsage;
    }

    static void Main()
    {
        Process[] processes = Process.GetProcesses();

        Console.WriteLine("===== Running Processes =====\n");

        foreach (Process process in processes)
        {
            try
            {
                IntPtr hProcess = OpenProcess(
                    PROCESS_QUERY_INFORMATION | PROCESS_VM_READ,
                    false,
                    process.Id);

                if (hProcess != IntPtr.Zero)
                {
                    PROCESS_MEMORY_COUNTERS memCounters;

                    bool success = GetProcessMemoryInfo(
                        hProcess,
                        out memCounters,
                        (uint)Marshal.SizeOf(typeof(PROCESS_MEMORY_COUNTERS)));

                    if (success)
                    {
                        ulong memoryMB =
                            memCounters.WorkingSetSize / 1024 / 1024;

                        Console.WriteLine(
                            $"Name : {process.ProcessName}");

                        Console.WriteLine(
                            $"PID  : {process.Id}");

                        Console.WriteLine(
                            $"RAM  : {memoryMB} MB");

                        Console.WriteLine(
                            "---------------------------");
                    }

                    CloseHandle(hProcess);
                }
            }
            catch
            {
                // بعض العمليات محمية
            }
        }
    }
}