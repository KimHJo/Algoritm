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

            for (int k= 0; k < numbers.Length; k++) {
                int j = 0;

                for (int i = numbers.Length - 1; i >= 0; i--) {

                    var str = numbers[j].ToString() + numbers[j + 1].ToString();
                    var str2 = numbers[j + 1].ToString() + numbers[j].ToString();

                    if (int.Parse(str) <= int.Parse(str2)) {
                        swap(numbers, j, j + 1);
                    }

                    j++;

                }
            }
            string answer = "";

            foreach(var c in numbers) {
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
