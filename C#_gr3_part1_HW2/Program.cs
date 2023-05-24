// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# Sharp program:\n");
Console.WriteLine("print the sum of two numbers");
Console.WriteLine("     the sum of numbers 1 and 2 is: " + (1 + 2));
Console.WriteLine("print the result of dividing two numbers");
Console.WriteLine("     the result of dividing 5 by 2 is: " + ((double)5 / 2));
Console.WriteLine("print the result of the specified operations");
Console.WriteLine("     -1 + 4 * 6, the result is: " + (-1 + 4 * 6));
Console.WriteLine("     (35 + 5) % 7, the result is: " + ((35 + 5) % 7));
Console.WriteLine("     14 + -4 * 6 / 11, the result is: " + (14 + (double)-4 * 6 / 11));
Console.WriteLine("     2 + 15 / 6 * 1 - 7 % 2, the result is: " + (2 + (double)15 / 6 * 1 - 7 % 2) + "\n");

int input1, input2, temp;

Console.WriteLine("swap two numbers");
Console.Write("     Please enter your first numeric value... ");
input1 = Convert.ToInt32(Console.ReadLine());
Console.Write("     Please enter your second numeric value... ");
input2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n     And after some magic, your fisrt number is " + input2 + "; and your second number is " + input1);

temp = input1;
input1 = input2;
input2 = temp;
Console.WriteLine("\n     Or we can do it in an expected way (hopefully?), the result is the same to the user...");
Console.WriteLine("     After the swapping, your fisrt number is " + input1 + "; and your second number is " + input2 + "\n");

int in1, in2, in3;

Console.WriteLine("print the output of multiplication of three numbers which will be entered by the user");
Console.Write("     Please enter your #1 numeric value to be multiplied... ");
in1 = Convert.ToInt32(Console.ReadLine());
Console.Write("     Please enter your #2 numeric value to be multiplied... ");
in2 = Convert.ToInt32(Console.ReadLine());
Console.Write("     Please enter your #3 numeric value to be multiplied... ");
in3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n     And after the multiplication the result is: " + in1 * in2 * in3 + "\n");