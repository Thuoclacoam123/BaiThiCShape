using BaithiC_;
using Microsoft.Identity.Client;
using System;

internal class Program
{

    private static void Main(string[] args)
    {
        ProductController pc = new ProductController();
        while (true)
        {

            Console.WriteLine("\n=============Menu==========");
            Console.WriteLine("o 1. Add product records\r\no 2. Display product records\r\no 3. Delete product by Id\r\no 4. Exit\r\n");
           

            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    pc.New();
                    break;
                case 2:
                    pc.ViewAll();
                    break;
                case 3:
                    pc.Delete();
                    break;
                case 4:

                    break;
            }

        }
    }
}
