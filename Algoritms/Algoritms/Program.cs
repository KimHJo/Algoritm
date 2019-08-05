using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            int[] Array = new int[] { 1, 5, 2, 6, 3, 7, 4 };

            int[,] Command = new int[,] {
                {2, 5, 3 },
                {4, 4, 1 },
                {1, 7, 3 },
            };

            
            foreach(var i in solution(Array, Command)) {
                Console.WriteLine(i);
            }
        }
        public static int[] solution(int[] array, int[,] commands) {
            int[] answer = new int[] { };
            int[] temp = new int[] { };
            for(int i = 0; i < commands.Length / 3; i++) {
                for(int j = commands[i, 0]-1; j< commands[i,2]; j++) {
                    for(int k = 0; k < commands[i,0] - commands[i,2]; k++) {
                        temp[k] = array[j];
                    }
                }
                Array.Sort(temp);
                answer[i] = temp[commands[i, 2]];
            }

            return answer;

        }
    }
}
