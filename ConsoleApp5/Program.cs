using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //#endregion



            //#region 2
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i * num);

            //}
            //#endregion



            //#region 3
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 2; i < num; i += 2)
            //{
            //    Console.WriteLine(i);
            //} 
            //#endregion



            //#region 4
            //Console.Write("enter the number ");
            //int n = int.Parse(Console.ReadLine());

            //Console.Write("enter the power");
            //int p = int.Parse(Console.ReadLine());


            //int result = 1;
            //for (int i = 1; i <= p; i++)
            //{
            //    result *= n;
            //}

            //Console.WriteLine(" the result is " + result); 
            //#endregion


            //#region 5
            //int[] mark = new int[5];
            //int total = 0;
            //Console.WriteLine("enter marks");
            //for (int i = 0; i < 5; i++)
            //{
            //    mark[i] = int.Parse(Console.ReadLine());
            //    total += mark[i];

            //}
            //int avg = total / 5;
            //int percentage = (total / 500) * 100;
            //Console.WriteLine(total);
            //Console.WriteLine(avg);
            //Console.WriteLine(percentage);

            //#endregion




            //#region 6
            //Console.Write("Enter the month number ");
            //int month = int.Parse(Console.ReadLine());

            //int days = 0;
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;

            //    case 2:
            //        days = 28;
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number");
            //        return;

            //}

            //Console.WriteLine($"Days in month {month}: {days}");


            //#endregion


            //#region 7
            //Console.WriteLine("enter first number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the operator:");
            //char op = char.Parse(Console.ReadLine());
            //Console.WriteLine("enter second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //int result = 0;
            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Error: Invalid operator.");
            //        return;
            //}
            //Console.WriteLine(result);
            //#endregion




            //#region 8
            //Console.WriteLine("enter integer");
            //string num = Console.ReadLine();
            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(num[i]);
            //}
            //#endregion




            //#region 9
            //Console.WriteLine("enter start number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter end number");
            //int num2 = int.Parse(Console.ReadLine());
            //for (int i = num1; i <= num2; i++)
            //{
            //    bool isPrime = true;
            //    if (i <= 1)
            //        continue;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //} 
            //#endregion

        }
    }
    
}
    

