using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAassign1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool select = false;
            int list_items;
            Console.WriteLine("Calculating Rectangle area & perimeter");
            try
            {
                rectangleClass solution = new rectangleClass();
                while (true) //used for infinte loop condition i.e., until the user exists the program
                {
                    do
                    {
                        Console.WriteLine("Rectangle is " + solution.getLength() + "x" + solution.getWidth() + "\n");
                        Console.WriteLine("User Guide:");
                        Console.WriteLine("1.Get Rectangle Length \n2.Change Rectangle Length \n3.Get Rectangle Width \n4.Change Rectangle Width \n5. Get Rectangle Perimeter \n6. Get Rectangle Area \n7. Exit");
                        Console.WriteLine("select your choice: ");
                        list_items = Convert.ToInt32(Console.ReadLine()); //Getting input from user 
                        if (list_items >= 1 && list_items <= 7) //verify if the user is selecting a valid item from the list
                        {
                            select = true;
                        }
                        else
                        {
                            Console.WriteLine("Please provide a valid input!");
                        }
                    } while (select == false); // Loop until user enters correct input


                    switch (list_items)
                    {
                        case 1:
                            Console.WriteLine("The length of rectangle is: " + solution.getLength());
                            break;

                        case 2:
                            Console.WriteLine("Enter length of rectangle: ");
                            int length = Convert.ToInt32(Console.ReadLine());
                            if (length > 0)
                            {
                                solution.setLength(length);
                            }
                            else
                            {
                                Console.WriteLine("Please enter the length value");
                            }
                            Console.WriteLine("\n");
                            break;

                        case 3:
                            Console.WriteLine("The width of rectangle is: " + solution.getWidth());
                            break;

                        case 4:
                            Console.WriteLine("Enter width of rectangle: ");
                            int width = Convert.ToInt32(Console.ReadLine());
                            solution.setWidth(width);
                            if (width > 0)
                            {
                                solution.setWidth(width);
                            }
                            else
                            {
                                Console.WriteLine("Please enter the width value");
                            }
                            Console.WriteLine("\n");
                            break;

                        case 5:
                            Console.WriteLine("Perimeter of rectangle is: " + solution.getPerimeter());
                            break;

                        case 6:
                            Console.WriteLine("Area of rectangle is: " + solution.getArea());
                            break;

                        case 7:
                            Environment.Exit(0); //Exiting the program
                            break;
                    }
                }
            }

            catch (Exception e) // used to Catch input exceptions
            {
                Console.WriteLine("Input is invalid \nSorry, Now Program will  exit");
            }

            Console.ReadLine();
        }
    }
}

