using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameCollection {
    class Program {
        static void Main(string[] args) {

            int input;

            do {
                Console.WriteLine("\nWelcome to the ConsoleGameCollection!");
                Console.WriteLine("\t-By Junker and Thuesen\n");
                Console.WriteLine("Chosse an option below:");
                Console.WriteLine("1. SomeGame");
                Console.WriteLine("2. SomeOtherGame");
                Console.WriteLine("3. SomeOtherThirdGame");
                Console.WriteLine("0. Exit\n");
                Console.Write("input > ");
                input = int.Parse(Console.ReadLine());

            } while(input != 0);

        }
    }
}
