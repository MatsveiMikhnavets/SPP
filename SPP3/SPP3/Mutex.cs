using System.Threading;

namespace SPP3
{
    public class Mutex
    {
        private int _curId = -1;

        public void Lock()
        {
            var id = Thread.CurrentThread.ManagedThreadId;
            while (Interlocked.CompareExchange(ref _curId, id, -1) != -1)
            {
                Thread.Sleep(10);
            }
        }

        public void Unlock()
        {
            var id = Thread.CurrentThread.ManagedThreadId;
            Interlocked.CompareExchange(ref _curId, -1, id);
        }
    }
}