/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class SubThreeNumbers {
  static void Main() {
      try{
          //Declare Three variables
          int a=10;
          int b=20;
          int c=30;
          //input numbers
          Console.Write("Enter first value");
          a=Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter second value");
          b=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter third value");
         
          //Calculating Substruction
          int sub=a-b;
          Console.WriteLine("Addition of "+ a +" and "+ b +" and "+ c + "is ="+sub);
      }
      catch(Exception ex){
          Console.WriteLine("Error: "+ ex.ToString());
          
      }
          
          
      
  }
}
