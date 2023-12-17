using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_6_task_3
{
    public class Cache
    {
        public TResult Result { get; }
        public DateTime Timestamp { get; }

        public Cache(TResult result, DateTime timestamp)
        {
            Result = result;
            Timestamp = timestamp;
        }
    }

    public class TResult
    {
    }
}