using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var array = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        var min = array[0];
        var max = array[0];
        var allSum = array[0];
        for (var i = 1; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
            }
            
            if (array[i] > max) {
                max = array[i];
            }
            
            allSum += array[i];
        }
        
        Console.WriteLine((allSum - max) + " " + (allSum - min));
    }
}
