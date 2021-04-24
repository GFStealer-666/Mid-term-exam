using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, time;
            string set;
            int breakfast = 5; int coffee = 3; int weekend = 2;

            Console.Write("Day : ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Time : ");
            time = int.Parse(Console.ReadLine());


            while (true)
                {
                   Console.Write("Command : ");
                    set = Console.ReadLine();
                    
                    if (set != "Breakfast set" && set != "Weekend set" && set != "Coffee" && set != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        continue;
                    }
                    if (set == "Breakfast set")
                    {
                        if (breakfast == 0 || time > 11)
                        {
                            Console.WriteLine("Sorry your order is not available");
                            continue;
                        }
                        else
                            breakfast = breakfast - 1;
                    }
                    if (set == "Coffee")
                    {


                    if (coffee == 0)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        continue;
                    }
                    else
                        coffee--;
                    }
                    if (set == "Weekend set")
                    {
                        if ((day >= 1 && day <= 5) || weekend == 0)
                        {
                        Console.WriteLine("Sorry your order is not available");
                        continue;
                        }
                        else
                        weekend--;
                    }
                
                    if (set == "End")
                    {
                         break;
                    }

                
            }
            Console.ReadLine();




        }
    }
}
