﻿using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            int[] Array = new int[] { 1, 5, 2, 6, 3, 7, 4, };

            int[,] Command = new int[,] {
                {2, 5, 3 },
                {4, 4, 1 },
                {1, 7, 3 },
            };

            var temp = new List<int>();
            var answer = new List<int>();

            for (int i = 0; i < Command.Length / 3; i++) {
                for (int j = Command[i, 0]; j <= Command[i, 1]; j++) {
                    temp.Add(Array[j - 1]);
                }
                temp.Sort();
                answer.Add(temp[Command[i, 2]-1]);
                temp.Clear();
            }

            foreach (var i in answer) {
                Console.WriteLine(i);
            }

        }
        public static int[] solution(int[] array, int[,] commands) {
            int[] answer = new int[] { };

            return answer ;

        }
    }
}
