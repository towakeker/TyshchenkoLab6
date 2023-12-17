using System;

namespace Lab_6_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CacheFunction<int, string> cache = new CacheFunction<int, string>(ExpensiveFunction);
            string result1 = cache.GetResult(5, TimeSpan.FromSeconds(10));
            Console.WriteLine(result1);
            System.Threading.Thread.Sleep(5000);
            string result2 = cache.GetResult(5, TimeSpan.FromSeconds(10));
            Console.WriteLine(result2);
        }
        static string ExpensiveFunction(int key)
        {
            Console.WriteLine("Executing expensive function...");
            return $"Result for key {key}";
        }
        }
    }