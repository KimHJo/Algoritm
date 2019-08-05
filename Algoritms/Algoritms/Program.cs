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

            int[] Numbers3 = new int[] { 0,0,0 };

            Console.WriteLine(solution(Numbers3));

            Array.Sort(Numbers, (x, y) => {
                string xy = x.ToString() + y.ToString();
                string yx = y.ToString() + x.ToString();
                return yx.CompareTo(xy);
            });

            if (Numbers.Where(x => x == 0).Count() == Numbers.Length)
                Console.WriteLine("DDD");
            else
                Console.WriteLine(string.Join("", Numbers));
            
        }
        public static string solution(int[] numbers) {
            int numleng = numbers.Length;
            List<string> numList = new List<string>();

            foreach(int c in numbers) {
                numList.Add(c.ToString());
            }

            for(int i = 0; i < numleng; i++) {
                for(int j = 0; j < numleng -1; j++) {
                    string str1 = numList[j] + numList[j + 1];
                    string str2 = numList[j + 1] + numList[j];

                    if(Int64.Parse(str1) >= Int64.Parse(str2)) {
                        swap(numbers, j, j + 1);
                    }
                }
            }
            string answer = "";

            foreach(int c in numbers.Reverse()) {
                answer += c.ToString();
            }
            if (int.Parse(answer) == 0)
                answer = "0";
            return answer;
        }
        public static void swap(int[] array, int a, int b) {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
