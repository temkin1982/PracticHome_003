using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace TMS_Practic_004
{
    internal class Program
    {
        static void Main(string[] args)
        {    //tasks 1.1 

            //for (int i = 1; i <= 99; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("_________________________________");

            //tasks 1.2

            //for (int i = 5; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("_____________________________");

            //tasks 1.3
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}
            //Console.WriteLine("_________________________");

            //tasks 1.4

            //int i = 7;
            //while (i <= 98)
            //{
            //    Console.WriteLine(i);
            //    i+=7;
            //}
            //Console.WriteLine("_________________________");

            //tasks 1.5

            //for (int i = 0; i > -50; i-=5)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("____________________________");

            //tasks 1.6

            //for (int i = 10; i <= 20; i++)
            //{
            //    Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
            //}
            //Console.WriteLine("__________________________");

            //tasks 2.0 Array:


            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15 };
            //bool result = false;
            //int checkArray = int.Parse(Console.ReadLine());
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] == checkArray)
            //    {
            //        result = true;
            //    }

            //}
            //if (result) { Console.WriteLine("yes"); }
            //else { Console.WriteLine("no"); }
            //Console.WriteLine("_________________________________");

            //tasks 2.1 Array:

            //int[] source = { 5, 4, 7, 2, 9, 7, 10 };
            //int numberReadLine = Convert.ToInt32(Console.ReadLine());
            //int futureArrayLength = 0;
            //foreach (int item in source)
            //{
            //    if (item != numberReadLine)
            //    {
            //        futureArrayLength++;
            //    }
            //}

            //int[] resultArray = new int[futureArrayLength];

            //int iterationForAppend = 0;

            //for (int i = 0; i < source.Length; i++)
            //{
            //    if (source[i] != numberReadLine)
            //    {
            //        if (iterationForAppend != resultArray.Length)
            //        {
            //            resultArray[iterationForAppend] = source[i];
            //            iterationForAppend++;
            //        }
            //    }
            //}
            //tasks 2.2 Array:

            //Console.Write("Enter elements count: ");
            //int elementsCount = int.Parse(Console.ReadLine());
            //int[] myArray = new int[elementsCount];
            //Random ran = new Random();

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = ran.Next(); //  если поставить значение 1 , 10 то будет лучше видно как код работает
            //}

            //Console.WriteLine("The elements:  ");

            //int maxElement = myArray[0];
            //int middArr = myArray.Length / 2;
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("The random elemnt: " + i + " . " + myArray[i]);
            //    if (myArray[i] > maxElement)
            //        maxElement= myArray[i];



            //}
            //Console.WriteLine($"\n The minimum number is: {myArray.Min()}");
            //Console.WriteLine($"\n The middle number is: {myArray[middArr]}");
            //Console.WriteLine($"\n The max element is:  {maxElement}");

            //tasks 2.3 Array:

            //int[] myArray1 = { 1, 2, 3, 4, 5 };
            //int[] myArray2 = { 10, 20, 30, 40, 50 };
            //int sum1 = 0;
            //int sum2 = 0;
            ////int arithmetic1 = myArray1.Length / 5; 
            //int maxElement1 = myArray1[0];
            //for (int i = 0; i < myArray1.Length; i++)
            //{
            //    Console.Write($"{i}) My Array one: {myArray1[i]}\n");
            //    sum1 += myArray1[i];    
            //    if (myArray1[i] > maxElement1)
            //       maxElement1= myArray1[i];
            //}
            ////Console.WriteLine($"\n The max element is:  {maxElement1}");
            //int arithmetic2 = myArray2.Length / 5;
            //int maxElement2 = myArray2[0];
            //for (int j = 0; j < myArray2.Length; j++)
            //{
            //    Console.WriteLine($"{j}) My Array tow: {myArray2[j]}");
            //    sum2 += myArray2[j];
            //    if (myArray2[j] > maxElement2)
            //       maxElement2 = myArray2[j];
            //}
            //Console.WriteLine($"\n The max element is:  {maxElement1}");
            //Console.WriteLine($"\n The max element is:  {maxElement2}");
            //Console.WriteLine("\n The Array1 arithmetic is: " + (sum1 /5));
            //Console.WriteLine("\n The Array2 arithmetic is: " + (sum2 / 5));
            //if (sum1 > sum2)
            //{
            //    Console.WriteLine($"The arithmetic  myArray1 {(sum1 / 5)} is big from myArray2  {(sum2 / 5)}");
            //}
            //else if (sum1 == sum2)
            //{
            //    Console.WriteLine($"The arithmetic  {(sum1 / 5)} is equal with {(sum2 / 5)} ");
            //}
            //else
            //{
            //    Console.WriteLine($"The arithmetic  from myArray2: {(sum2 / 5)} is big from myArray1:  {(sum1 / 5)} ");
            //}
           
        }
    }    


}