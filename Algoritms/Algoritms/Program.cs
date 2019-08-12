using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(solution("1924", 2));
            Console.WriteLine(solution("4177252841", 4));

        }
        public static string solution(string number, int k) {
            // 0 인경우 예외처리
            if (number.All(x => x == '0'))
                return "0";

            // k가 최대값인경우 예외처리
            if (number.Length - k == 1)
                return number.Max().ToString();

            // 변수선언
            Stack<char> numStack = new Stack<char>();
            StringBuilder answer = new StringBuilder();
            List<char> numList = number.ToList<char>();

            // 예외처리로 인해 List[0] 는 항상 push 가능
            numStack.Push(numList[0]);


            for (int i = 0; i < k; i++) {


                // 만약 peek 랑 배열값이 같으면 push
                    // 만약 peek 보다 배열값이 작으면 push
                    // peek 보다 배열값이 크면 pop 및 배열값 push
                    // k번까지




            }

            //foreach(var c in numArray) {
            //    if (c != '0') answer.Append(c);
            //}

            return answer.ToString();
        }

    }
}