using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            var testCase = int.Parse(Console.ReadLine());

            var abLines = new List<string>();

            var answerList = new List<int>();
            for (int i = 0; i < testCase; i++) {
                abLines.Add(Console.ReadLine());

                var temp = abLines[i].Split(' ');

                var A = int.Parse(temp[0]) % 10;
                var B = int.Parse(temp[1]) % 10;

                answerList.Add((int)Math.Pow(A, B) % 10);
            }

            foreach(var c in answerList) {
                Console.WriteLine("{0}번 컴퓨터가 처리합니다.", c);
            }
        }
    }
}
