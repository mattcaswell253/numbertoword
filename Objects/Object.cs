using System;
using System.Collections.Generic;
using System.Linq;

 namespace NumbersApp.Objects
 {
     public class Numbers
     {
       private int _userInput;

       private Dictionary<int, string> _numberList = new Dictionary<int, string>()
       {
         {1,"one"},
         {2,"two"},
         {3,"three"},
         {4,"four"},
         {5,"five"},
         {6,"six"},
         {7,"seven"},
         {8,"eight"},
         {9,"nine"},
         {10,"ten"},
         {11,"eleven"},
         {12,"twelve"},
         {13,"thirteen"},
         {14,"fourteen"},
         {15,"fifteen"},
         {16,"sixteen"},
         {17,"seventeen"},
         {18,"eighteen"},
         {19,"nineteen"},
         {20,"twenty"}

       };

       private Dictionary<int, string> _DDList = new Dictionary<int, string>()
       {
         {2,"twenty"},
         {3,"thirty"},
         {4,"forty"},
         {5,"fifty"},
         {6,"sixty"},
         {7,"seventy"},
         {8,"eighty"},
         {9,"ninety"}
       };



       public Numbers(int numberInput)
       {
         _userInput = numberInput;

       }

       public int GetUserInput()
       {
         return  _userInput;
       }

       public string NumberToWord()
       {
         if(GetUserInput() < 21)
        {
        return _numberList[GetUserInput()];
        }
        else
        {
          int[] inputArr = GetUserInput().ToString().Select(t=>int.Parse(t.ToString())).ToArray();
          Console.WriteLine(inputArr[0]);
          Console.WriteLine(inputArr[1]);
          return _DDList[inputArr[0]] + _numberList[inputArr[1]];
        }

       }
    }
 }
