using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Algoritms {

    public class AB {
        public int A { get; set; }
        public int B { get; set; }

        public AB(int a, int b) {
            this.A = a;
            this.B = b;
        }
    }
    class Program {
        static void Main(string[] args) {
            var testCase = int.Parse(Console.ReadLine());

            var abLines = new List<string>();

            for (int i = 0; i < testCase; i++) {
                abLines.Add(Console.ReadLine());

                var temp = abLines[i].Split(' ');

                var A = int.Parse(temp[0]) % 10 + 1;
                var B = int.Parse(temp[1]) % 10 + 1;

                switch (A) {
                    case 1:
                    case 5:
                    case 6:
                        Console.WriteLine("1번 컴퓨터");
                        break;
                    case 3:
                        Console.WriteLine((B / 5 + 1) + "번 컴퓨터");
                        break;
                    case 2:
                    case 4:
                    case 7:
                    case 8:
                        Console.WriteLine((B / 4 + 1) + "번 컴퓨터");
                        break;
                    case 9:
                        Console.WriteLine((B / 2 + 1) + "번 컴퓨터");
                        break;
                }
            }
        }
    }
}
