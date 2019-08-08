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
            //char[] temp = number.ToArray();
            char[] numArray = number.ToArray();

            //int numLen = number.ToString().Length;
            int numLen = number.Length;

            for (int i = 0; i < k; i++) {
                for (int j = 0; j < numLen - 1; j++) {
                    if (numArray[j] == ' ')
                        break;

                    for (int s = j + 1; s < numLen; s++) {
                        if (numArray[s] == ' ')
                            s++;

                        if (numArray[j] == numArray[s]) {
                            s++;
                        } else if (numArray[j] > numArray[s]) {
                            numArray[s] = ' ';
                            break;
                        } else if (numArray[j] < numArray[s]) {
                            numArray[j] = ' ';
                            break;
                        }
                    }
                }
            }


            //for (int i = 0; i < k; i++) {
            //    for (int j = 0; j < numLen - 1; j++) {
            //        //Console.Write("i = {0}", i);
            //        for (int s = j + 1; s < numLen; s++) {

            //            Console.WriteLine("i값 : {0} / j값 : {1}", temp[j], temp[s]);
            //            if (temp[j] < temp[s]) {
            //                temp[j] = ' ';
            //                break;
            //            } else if (temp[j] > temp[s]) {
            //                temp[s] = ' ';
            //                break;
            //            } else {
            //                break;
            //            }
            //        }
            //    }
            //}

            //string answer = "";
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