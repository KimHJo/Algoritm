using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(solution(10));
        }
        public static bool solution(int x) {
            bool answer = true;

            var ar = x.ToString().ToArray();

            int sum = 0;
            foreach(var i in ar) {
                sum += i;
            }

            
            if (x % sum == 0) {
                answer = true;
            } else {
                answer = false;
            }

            return answer;
        }

    }
}