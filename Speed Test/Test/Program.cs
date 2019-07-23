using System;
namespace Test
{


    class Program
    {

        static void Main(string[] args)
        {

            const int demeritPointPerKm = 5;


            Console.WriteLine("Please enter the speed limit: ");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your speed: ");
            var speed = Convert.ToInt32(Console.ReadLine());



            if (speed <= limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demritPoint = (speed - limit) / demeritPointPerKm;
                if (demritPoint >= 12)
                {
                    Console.WriteLine("Suspended");
                }
                    else
                {
                    Console.WriteLine("Demerit Points: " + demritPoint);
                }

                
            }
        }

               

           
            
        }
            

            

        }
            
    

