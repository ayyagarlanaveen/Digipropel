/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class AddTwoNumbers {
  static void Main() {
      try{
          //Declare two variables
          int a=10;
          int b=20;
          //input numbers
          Console.Write("Enter first value");
          a=Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter second value");
          b=Convert.ToInt32(Console.ReadLine());
          //Calculating sum
          int sum=a+b;
          Console.WriteLine("Addition of "+ a +" and "+ b +" is ="+sum);
      }
      catch(Exception ex){
          Console.WriteLine("Error: "+ ex.ToString());
          
      }
          
          
      
  }
}
