using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int height , width , num ,n,x,z;
            string var;

            var = Console.ReadLine();

            Console.Write("Width : ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Height : ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Number : ");
            num = int.Parse(Console.ReadLine());

            int i = width;

            for (z = 1; z<= num; z++)
            {              
               if (z > 1)
                {
                    width = width + i;
                } 
                for (n = 1; n <= height; n++)
                {
                    for (x = 2; x <= width; x++)
                    {                      
                     Console.Write(var);
                    }
                    Console.WriteLine(var);
                }              
            }
           Console.ReadLine();
            
            
            
        }
    }
}
