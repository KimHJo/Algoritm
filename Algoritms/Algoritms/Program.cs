﻿using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            solution(8, 1);
        }
        public static int[] solution(int brown, int red) {
            int row = 0;
            int col = 0;

            List<int> aliquot = new List<int>();

            int sum = red + brown;

            for (int i = 1; i <= Math.Sqrt(sum); i++) {
                if (sum % i == 0) {
                    aliquot.Add(i);
                    aliquot.Add(sum / i);
                }
            }

            for (int i = 0; i < aliquot.Count(); i = i + 2) {
                if (aliquot[i] + aliquot[i+1] == (brown + 4) / 2) {
                    row = aliquot[i + 1];
                    col = aliquot[i];
                }
            }

            int[] answer = new int[] { row, col};
            return answer;
        }
    }
}