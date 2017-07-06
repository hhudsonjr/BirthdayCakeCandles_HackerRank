using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
  
  static string timeConversion(string s) {
    //Complete this function
    
    //Declare string value - mTime for Military Time
    string mTime = DateTime.Now.ToString();
    //Declare parameter DateTime - sTime for Standard Time(input)
    DateTime sTime;
    
    if (DateTime.TryParse(s, out sTime)) {
      mTime = sTime.ToString("HH:mm:ss tt");
      }
      return mTime;
    }
   
    static void Main(string[] args) {
      string s = Console.ReadLine();
      string result = timeConversion(s);
      Console.WriteLine(result);
      }
  }