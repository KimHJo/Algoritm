using System;
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


            foreach (var item in solution(Array, Command)) {
                Console.WriteLine(item);
            }
        }
        public static int[] solution(int[] array, int[,] commands) {
            List<int> answer = new List<int>();

            var temp = new List<int>();

            var commandsLen = commands.Length / 3;

            for(int i = 0; i < commandsLen; i++) {
                var start = commands[i, 0] - 1;
                var end = commands[i, 1] - 1;
                var index = commands[i, 2] - 1;

                for (int j = start; j <= end; j++) {
                    temp.Add(array[j]);
                }
                temp.Sort();
                answer.Add(temp[index]);
                temp.Clear();
            }

            return answer.ToArray();

        }
    }
}
