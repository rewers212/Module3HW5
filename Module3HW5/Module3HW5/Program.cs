using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Module3HW5
{
     public class Program
    {
        public static void Main(string[] args)
        {
            var text = Result().GetAwaiter().GetResult();
        }

        public static async Task<string> ReadHello()
        {
            var filepath = @"Hello.txt";
            var text = await File.ReadAllTextAsync(filepath);
            return text;
        }

        public static async Task<string> ReadWorld()
        {
            var filePath = @"World.txt";
            var text = await File.ReadAllTextAsync(filePath);
            return text;
        }

        public static async Task<string> Result()
        {
        }
    }
}
