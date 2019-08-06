﻿using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            int i = 10;

            Console.WriteLine(solution(i));
        }
        public static int solution(int n) {
            int answer = n - 1;

            bool[] prime = Enumerable.Repeat(true, n + 1).ToArray();

            for (int i = 2; (i * i) <= n; i++) {
                if (prime[i] == false) continue;

                for (int j = i * i; j <= n; j += i) {
                    if (prime[j] == false) continue;

                    prime[j] = false;
                    answer--;
                }
            }

            return answer;
        }
    }
}
