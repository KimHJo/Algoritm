using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {

            int[] Answer = new int[] { 1, 2, 3, 4, 5 };

            foreach(var c in solution(Answer)) {
                Console.WriteLine(c);
            }
        }

        public static int[] solution(int[] answers) {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int[] B = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] C = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int Aindex = 0;
            int Bindex = 0;
            int Cindex = 0;

            int Acount = 0;
            int Bcount = 0;
            int Ccount = 0;

            for (int i = 0; i < answers.Length; i++) {
                if (Aindex >= A.Length) Aindex = 0;
                if (Bindex >= B.Length) Bindex = 0;
                if (Cindex >= C.Length) Cindex = 0;

                if (answers[i] == A[Aindex]) Acount++;
                if (answers[i] == B[Bindex]) Bcount++;
                if (answers[i] == C[Cindex]) Ccount++;

                Aindex++;
                Bindex++;
                Cindex++;
            }

            int[,] chart = new int[,] {
                {1, Acount },
                {2, Bcount },
                {3, Ccount }
            };

            int maxScore = Math.Max(Acount, Math.Max(Bcount, Ccount));

            List<int> answer = new List<int>();

            for(int i = 0; i < 3; i++) {
                if (chart[i, 1] >= maxScore)
                    answer.Add(chart[i, 0]);
            }

            return answer.ToArray();
        }
    }
}