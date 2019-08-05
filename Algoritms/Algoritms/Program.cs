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

            //var temp = new List<int>();
            //var answer = new List<int>();

            //for (int i = 0; i < Command.Length / 3; i++) {
            //    for (int j = Command[i, 0]; j <= Command[i, 1]; j++) {
            //        temp.Add(Array[j - 1]);
            //    }
            //    temp.Sort();
            //    answer.Add(temp[Command[i, 2]-1]);
            //    temp.Clear();
            //}

            //foreach (var i in answer) {
            //    Console.WriteLine(i);
            //}

        }
        public static int[] solution(int[] array, int[,] commands) {
            List<int> answer = new List<int>();

            var temp = new List<int>();

            foreach(var i in array) {
                answer.Add(i);
            }

            //for(int i = 0; i < commands.Length/3; i++) {
            //    for(int j = commands[i,0]; j < commands[i,1]; j++) {
            //        temp.Add(array[j - 1]);
            //    }
            //    temp.Sort();
            //    answer.Add(temp[commands[i, 2] - 1]);
            //    temp.Clear();
            //}

            return answer.ToArray();

        }
    }
}
