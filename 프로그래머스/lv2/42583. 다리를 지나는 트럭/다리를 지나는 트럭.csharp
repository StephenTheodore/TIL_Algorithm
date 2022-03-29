using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    class Truck
        {
            public int onBridgeTime = 0;
            public int weight;
            public bool isOnBridge = false;
            public Truck(int weight)
            {
                this.weight = weight;
            }
        }
    public int solution(int bridge_length, int bridge_weight, int[] truck_weights) {
                                    int elapsedTime = 0;
            int totalWeightOnBridge = 0;
            int totalTrucksOnBridge = 0;
            List<Truck> listTruck = new List<Truck>();

            for (int i = 0; i < truck_weights.Length;i++ )
            {
                listTruck.Add(new Truck(truck_weights[i]));
            }
            while (listTruck.Count != 0)
            {
                for (int i = 0; i < listTruck.Count; i++)
                {
                    if (listTruck.ElementAt(i).isOnBridge)
                    {
                        listTruck.ElementAt(i).onBridgeTime++;
                    }
                    else
                        break;
                }
                if (listTruck.ElementAt(0).onBridgeTime >= bridge_length)
                {
                    totalWeightOnBridge -= listTruck.ElementAt(0).weight;
                    totalTrucksOnBridge--;
                    listTruck.RemoveAt(0);
                }
                for (int i = 0; i < listTruck.Count; i++)
                {
                    if (!listTruck.ElementAt(i).isOnBridge)
                    {
                        if (totalTrucksOnBridge + 1 <= bridge_length && listTruck.ElementAt(i).weight + totalWeightOnBridge <= bridge_weight)
                        {
                            listTruck.ElementAt(i).isOnBridge = true;
                            totalWeightOnBridge += listTruck.ElementAt(i).weight;
                            totalTrucksOnBridge++;
                        }
                        else
                            break;
                    }
                }
                elapsedTime++;
            }
            return elapsedTime;
    }
}