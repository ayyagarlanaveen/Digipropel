/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;  
public class Exercise59
{  
    public static void Main()
        {
    int row,column; 
   
    Console.Write("\n\n");
    Console.Write("Display the pattern like 'B' with an asterisk:\n");
    Console.Write("---------------------------------------------");
    Console.Write("\n\n");   
 
   for(row=0;row<=6;row++)
        {
         for (column=0; column<=6; column++)
            {
            if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
              Console.Write("*");
             else
              Console.Write(" ");
            }
            Console.Write("\n");
        }
	Console.Write("\n");
   }
}
