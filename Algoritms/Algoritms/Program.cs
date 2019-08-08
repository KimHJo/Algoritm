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
            if (number.All(x => x == '0'))
                return "0";

            char[] numArray = number.ToArray();

            int count = 0;
            while (count < k) {

                for (int i = 0; i < numArray.Length-1; i++) {
                    if (numArray[i] == '0')
                        continue;

                    for (int j = i+1; j < numArray.Length; j++) {
                        if (numArray[j] == '0')
                            continue;

                        //Console.WriteLine("{0} {1} {2} {3}", i, j, numArray[i], numArray[j]);

                        if(numArray[i] == numArray[j]) {

                        }

                        if(numArray[i] < numArray[j]) {
                            numArray[i] = '0';
                            i = numArray.Length;
                            break;
                        }

                        if (numArray[i] > numArray[j]) {
                            numArray[j] = '0';
                            i = numArray.Length;
                            break;
                        }

                    }
                }

                count++;
            }

            StringBuilder answer = new StringBuilder();

            foreach(var c in numArray) {
                if (c != '0') answer.Append(c);
            }

            return answer.ToString();
        }

    }
}