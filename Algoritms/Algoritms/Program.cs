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
            char[] temp = number.ToArray();

            int numLen = number.ToString().Length;

            for (int i = 0; i < k; i++) {
                // i = 0 1 
                for (int j = i; j < numLen - 2; j++) {
                    // i = 0 : j = 0 1 2
                    // i = 1 : j = 1 2
                    for (int s = j + 1; s < numLen - 1; s++) {
                        // i = 0 : j = 0 : s = 1 2 3
                        // i = 0 : j = 1 : s = 2 3
                        // i = 0 : j = 2 : s = 3

                        // i = 1 : j = 1 : s = 2 3
                        // i = 1 : j = 2 : s = 3
                        if (temp[j] == temp[s]) {
                            j++;
                        } else if (temp[j] < temp[s]) {
                            temp[j] = ' ';
                            break;
                        } else {
                            temp[s] = ' ';
                            break;
                        }
                    }
                }
            }

            string answer = "";

            foreach(char c in temp) {
                if( c != ' ') {
                    answer += c;
                }
            }

            return answer;
        }

    }
}