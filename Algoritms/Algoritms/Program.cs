using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Algoritms {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(solution(2, 10, new int[] { 7, 4, 5, 6 }));
            Console.WriteLine(solution(100, 100, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }));
        }
        public static int solution(int bridge_length, int weight, int[] truck_weights) {
            int day = 0;
            int truck_index = 0;


            #region <List>
            //List<int> bridge = Enumerable.Repeat(0, bridge_length).ToList();

            //while (truck_index < truck_weights.Length) {
            //    day++;

            //    bridge.RemoveAt(0);

            //    if (bridge.Sum() + truck_weights[truck_index] <= weight) {
            //        bridge.Add(truck_weights[truck_index]);

            //        truck_index++;
            //        continue;
            //    }

            //    bridge.Add(0);
            //}
            #endregion

            #region <Queue>
            Queue<int> bridge = new Queue<int>();

            //init
            for (int i = 0; i < bridge_length; i++) {
                bridge.Enqueue(0);
            }

            while (truck_index < truck_weights.Length) {
                day++;

                bridge.Dequeue();

                if (bridge.Sum() + truck_weights[truck_index] <= weight) {
                    bridge.Enqueue(truck_weights[truck_index]);

                    truck_index++;
                    continue;
                }

                bridge.Enqueue(0);
            }
            #endregion

            return day + bridge_length;
        }
    }
}