using System;
using System.Runtime.InteropServices;
using Win32.Models;

namespace Win32.Libraries
{
    public static class kernal32
    {
        #region kernal32.dll
        [DllImport("kernel32.dll")]
        public static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32")]
        public static extern int FormatMessage(
          int dwFlags,
          IntPtr lpSource,
          int dwMessageId,
          int dwLanguageId,
          string lpBuffer,
          uint nSize,
          int argumentsLong);
        
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetFileAttributes(string lpFileName);

        [DllImport("kernel32")]
        public static extern int GetLastError();

        [DllImport("Kernel32.dll")]
        public static extern void GetLocalTime([In, Out] SystemTime st);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion
    }
}
