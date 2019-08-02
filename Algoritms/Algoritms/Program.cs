using System;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {

            var testCase = 0;
            testCase = int.Parse(Console.ReadLine());

            var abLines = new List<string>();
            for (int i = 0; i < testCase; i++)
                abLines.Add(Console.ReadLine());


            Console.WriteLine(testCase);
            foreach (var line in abLines)
                Console.WriteLine(line);
        }
    }
}
