using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emoji = char.ConvertFromUtf32(0x1F3AE);  // 🎮
            Console.WriteLine($"{emoji} 게임 개발");
        }
    }
}
