using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            double fLength, fov;
            string mode;
            Console.WriteLine("Mode : ");
            mode = Console.ReadLine();

            float FilmBackWidth;

            while (1>0)
            {
                Console.WriteLine("FilmBackWidth: ");
                FilmBackWidth = float.Parse(Console.ReadLine());

                if (FilmBackWidth < 0)
                {
                    Console.WriteLine("Invaild filmBackWidth Please input again");
                    continue;
                }

                if (FilmBackWidth > 0)
                {
                   

                    if (mode == "fLength")
                    {
                        while (true)
                        {
                            Console.WriteLine("Input fLength = ");
                            fLength = double.Parse(Console.ReadLine());

                            if (fLength < 0)
                            {
                                Console.WriteLine("Invaild fLength Please input again");
                                continue;
                            }
                            else
                                fov = 2 * Math.Atan(FilmBackWidth / (2 * fLength));
v
                        }
                       
                    }
                    if (mode == "fov")


                        while (true)
                        {
                            Console.WriteLine("Input fov = ");
                            fov = double.Parse(Console.ReadLine());

                            if (fov < 0.1 && fov > 6.28)
                            {
                                Console.WriteLine("Invaild fLength Please input again");
                                continue;
                            }
                            else
                                fLength = FilmBackWidth / (2 * Math.Tan(fov / 2));                
                        
                        }                 
                    
                    Console.WriteLine("{0} , {1} ", fLength, fov);
                }                
            
            }


        }







        }
    }
}
