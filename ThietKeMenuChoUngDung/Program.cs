using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeMenuChoUngDung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the retangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    int i=1;
                    Console.WriteLine("Input lenght of the triangle: ");
                    int LeghtoTr = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Triagle: ");
                    Console.WriteLine("");


                    while ( i <= LeghtoTr)
                    {
                        int j=1;
                        
                        while (j <= i)
                        {
                            j++;
                            Console.Write("*");
                        }
                        i++;
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                        break;
                case 2:
                    
                    int g = 1;
                    
                    Console.WriteLine("Input lenght of the square: ");
                    int LeghtoSq = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Square: ");
                    Console.WriteLine("");

                    while ( g <= LeghtoSq)
                    {
                        g++;
                        int h = 1;
                        
                        while ( h <= LeghtoSq)
                        {
                            h++;
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 3:
                    int x = 1;
                    
                    Console.WriteLine("Input lenght of the retangle: ");
                    int leghtoRe = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input height of the retangle: ");
                    int heghtoRe = int.Parse(Console.ReadLine());

                    Console.WriteLine("Retangle: ");
                    Console.WriteLine("");

                    while ( x <= heghtoRe) 
                    {
                        x++;
                        int y = 1;

                        while (y <= leghtoRe)
                        {
                            y++;
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case 0:
                    
                    Environment.Exit(0);
                    break;
                
                default:
                    
                    Console.WriteLine("No choice!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
