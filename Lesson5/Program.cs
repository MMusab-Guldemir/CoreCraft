using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            int number1;
            int number2;
            int number3;

            //yerine

            int[] numbers = new int[3] { 1, 2, 3 }; //süslü parantezi şu işe yarar.

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            var numbers1 = new int[3];
            numbers1[0] = 1;

            Console.WriteLine(numbers1[0]); //1
            Console.WriteLine(numbers1[1]); //0
            Console.WriteLine(numbers1[2]); //0



            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); //true
            Console.WriteLine(flags[1]); //false
            Console.WriteLine(flags[2]); //false


            var names = new string[3] { "john", "micheal", "rock" };


        }
    }
}
