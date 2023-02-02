using System;
using System.Collections;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();
            // queue.Enqueue("R&D");
            // queue.Enqueue(1234);
            // queue.Enqueue("Atlas");
            // queue.Enqueue(5678);
            // queue.Enqueue("Sunquest");
            // queue.Enqueue("Clinisys");
            // queue.Enqueue(91011);
            // queue.Enqueue("Roper");

            Console.WriteLine("Give Integer Input : \t press enter to exit");
            do
            {
                var inputEle = (Console.ReadLine());
                if (inputEle == "")
                    break;
                else
                {
                    int inputInt = Convert.ToInt32(inputEle);
                    queue.Enqueue(inputInt);

                }

            } while (true);


            System.Console.WriteLine("Original Queue: ");
            foreach (var e in queue)
                Console.Write(e + ", ");

            System.Console.WriteLine($"\nNumber of ELements: {queue.Count()}");
            System.Console.WriteLine();


            int lrg = 0;
            foreach (var item in queue)
            {
                if (item > lrg)
                    lrg = item;
            }
            System.Console.WriteLine($"Largest Elements: {lrg}");



            // queue.Dequeue();

            // System.Console.WriteLine("After deleteing: ");
            // foreach (var e in queue)
            //     Console.Write(e + ", ");
            // System.Console.WriteLine();
            // System.Console.WriteLine();
            // // System.Console.WriteLine("After trim: ");

            // foreach (var i in queue)
            //     System.Console.Write(i + ", ");

            // System.Console.WriteLine($"Peek Value: {queue.Peek()}");

            // System.Console.WriteLine($"NUmber of ELements: {queue.Count()}");
            // System.Console.WriteLine();

            // // queue.TrimToSize();


        }
    }
}