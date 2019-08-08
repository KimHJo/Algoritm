using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(solution("1924", 2));
            //Console.WriteLine(solution("4177252841", 4));
        }
        public static string solution(string number, int k) {
            char[] numArray = number.ToArray();

            int numLen = number.Length;

            //몇번 숫자를 공백처리것인가
            for (int i = 0; i < k; i++) {
                //비교숫자 1번 loop
                for (int j = 0; j < numLen - 1; j++) {
                    //비교숫자 2번 loop
                    for(int s = j+1; s< numLen; s++) {
                        Console.WriteLine("I:{0} J:{1} S:{2}", i, j, s);
                    }
                    Console.WriteLine();
                }
            }
            string answer = "";

            foreach (char c in numArray) {
                if (c != ' ') {
                    answer += c;
                }
            }

            return answer;
        }

    }
}