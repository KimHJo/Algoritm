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

            Console.WriteLine(solution(Numbers2));
            
        }
        public static string solution(int[] numbers) {

            int numleng = numbers.Length;
            for (int k = 0; k < numbers.Length; k++) {
                for (int i = 0; i < numbers.Length - 1; i++) {
                    var str1 = numbers[i].ToString() + numbers[i + 1];
                    var str2 = numbers[i + 1].ToString() + numbers[i].ToString();

                    if (int.Parse(str1) >= int.Parse(str2))
                        swap(numbers, i, i + 1);
                }
            }
            string answer = "";

            foreach(var c in numbers.Reverse()) {
                answer += c.ToString();
            }
            return answer;
        }
        public static void swap(int[] array, int a, int b) {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
