using System;
using System.Runtime.InteropServices;

namespace spp_lab4
{
    public class OSHandle:IDisposable
    {
        [DllImport("Kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);
        private IntPtr Handle { get; set; }
        
        private bool _disposed;

        public OSHandle(IntPtr handle)
        {
            Handle = handle;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                CloseHandle(Handle);
                Handle = IntPtr.Zero;
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        ~OSHandle()
        {
            Dispose ();
        }
    }
}