﻿using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            foreach (var c in solution(new int[] { 93, 30, 55 }, new int[] { 1, 30, 5 })) {
                Console.WriteLine(c);
            };
        }
        public static int[] solution(int[] progresses, int[] speeds) {
            Stack<int> ProgressStack = new Stack<int>();

            // Stack에 역순으로 Push
            for (int j = progresses.Length - 1; j >= 0; j--) {
                ProgressStack.Push(progresses[j]);
            }

            List<int> answer = new List<int>();

            int day = 1;
            int count = 0;
            int i = 0;

            while (ProgressStack.Count != 0 && ProgressStack.Peek() + day * speeds[i] < 100) {

                day++;

                while (ProgressStack.Count != 0 && ProgressStack.Peek() + day * speeds[i] >= 100) {
                    if (ProgressStack.Peek() + day * speeds[i] >= 100) {
                        ProgressStack.Pop();
                        count++;
                        i++;
                    }
                }

                if (count != 0) {
                    answer.Add(count);
                    count = 0;
                }
            }

            return answer.ToArray();
        }

    }
}