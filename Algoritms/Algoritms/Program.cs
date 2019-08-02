using System;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            int testCaseNumber = int.Parse(Console.ReadLine());

            string[] abLines = new string[testCaseNumber];
            
            for (int i = 0; i < testCaseNumber; i++) {
                abLines[i] = Console.ReadLine();
                string[] temp = abLines[i].Split(' ');

                int A = int.Parse(temp[0]) % 10;
                int B = int.Parse(temp[1]) % 10;

                //백준에서 이렇게 쓰면 정답이 아니란다... 그리고 코드길이가 길어졌네 당연한건가.
                //int t = (int)Math.Pow(A, B) % 10;
                //abLines[i] = t.ToString();

                // 계산이 너무 오래걸린다.
                //answerList.Add((int)Math.Pow(A, B) % 10);
            }
            foreach(string t in abLines) {
                Console.WriteLine(t);
            }
        }
    }
}
