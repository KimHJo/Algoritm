﻿using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            solution("-4 -3 -2 1 -1 2 4 3");
        }
        public static string solution(string s) {

            string[] cArr = s.Split(' ').ToArray();

            Array.Sort(cArr, (x, y) => {
                int ix = int.Parse(x.ToString());
                int iy = int.Parse(y.ToString());

                return ix.CompareTo(iy);
            }); 
            
            string answer = cArr[0] + " " + cArr[cArr.Length-1];
            return answer;
        }

    }
}