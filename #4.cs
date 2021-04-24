using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;

            Console.Write("x1 : ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("x2 : ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 = int.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
                step = Math.Abs(dy);
            
            dx = dx / step;
            dy = dy / step;

            x = x1;
            y = y1;

            int i = 1;

            while (i <= step)
            {                
                    Console.WriteLine("{0} , {1} ", x, y);
                    x += dx;
                    y += dy;                                                           
                    i++; 
            }
            
            
            Console.ReadLine();
        }
    }
}
