using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(solution("1924", 2));
            Console.WriteLine(solution("4177252841", 4));
        }
        public static string solution(string number, int k) {
            string answer = "";
            int count = k;
            var numList = number.ToList();
            if (number.All(x => x == '0'))
                return answer = "0";

            while(count > 0) {
                var list = numList.GetRange(0, k);

                var min = list.Min().ToString();
                numList.Remove(Convert.ToChar(min));
                count--;
            }
             answer = String.Join("", numList) ;

            return answer;
        }

    }
}