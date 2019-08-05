using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {

            int[] Numbers = new int[] { 6, 10, 2, };
            int[] Numbers2 = new int[] { 3, 30, 34, 5, 9, };

            solution(Numbers);

        }
        public static string solution(int[] numbers) {
            var numberList = numbers.ToList();
            numberList.AddRange(numberList);


            int i = 0;
            while (true){
                if (i == numbers.Length) break;
                int j = i;

                for (j = i; j < numbers.Length + i; j++) {
                    Console.Write(j);
                }
                Console.WriteLine("증가");

                for (j = numbers.Length + i - 1; j >= i; j--) {
                    Console.Write(j);
                }
                Console.WriteLine("감소");

                i++;
            }


            string answer = "";
            return answer;
        }
    }
}
