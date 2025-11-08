public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var startStation = 0;
        var sum = 0;
        var tank = 0;
        for(var i = 0; i< gas.Length; i++){
            var net = gas[i] - cost[i];
            tank+= net;
            sum+= net;

            if(tank<0) { //when tank is in negative, restart the startStation and calculation of tank from starting. while sum is total of all cost regardless of positive or negative
                startStation = i +1;
                tank = 0;
            }
        }

        return sum >=0? (startStation == gas.Length? 0 : startStation): -1;
    }
}