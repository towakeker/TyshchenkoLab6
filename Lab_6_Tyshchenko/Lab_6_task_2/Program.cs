using System;
using System.Collections.Generic;

namespace Lab_6_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<int> intRepository = new Repository<int>();
            Repository<string> stringRepository = new Repository<string>();

            AddDataToRepositories(intRepository, stringRepository);

            Console.WriteLine("Whole numbers greater than 5:");
            PrintResults(intRepository.Find(x => x > 5));

            Console.WriteLine("Strings starting with 'w':");
            PrintResults(stringRepository.Find(x => x.StartsWith("w")));
        }

        static void AddDataToRepositories(Repository<int> intRepository, Repository<string> stringRepository)
        {
            intRepository.Add(17);
            intRepository.Add(5);
            intRepository.Add(23);

            stringRepository.Add("map");
            stringRepository.Add("water");
            stringRepository.Add("book");
        }

        static void PrintResults<T>(List<T> results)
        {
            foreach (T item in results)
            {
                Console.WriteLine(item);
            }
        }
        }
    }