using System;

namespace RoverManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directions N, S, E, W
            // Location X, Y

            int maxX = 0;
            int maxY = 0;

            String firstRoverInformations;
            String firstRoverActCommands;

            String secondRoverInformations;
            String secondRoverActCommands;

            Console.WriteLine("Enter the max \"X Y\" values");

            String maxXY = Console.ReadLine();

            maxX = Convert.ToInt32(maxXY.Split(" ")[0]);
            maxY = Convert.ToInt32(maxXY.Split(" ")[1]);

            //First rover
            Console.WriteLine("Enter the first rovers first location information:");
            
            firstRoverInformations = Console.ReadLine();

            Rover r = new Rover(Convert.ToInt32(firstRoverInformations.Split(" ")[0]), Convert.ToInt32(firstRoverInformations.Split(" ")[1]), firstRoverInformations.Split(" ")[2],maxX,maxY);

            Console.WriteLine("Enter the first rovers act commands:");

            firstRoverActCommands = Console.ReadLine();


            //Second rover
            Console.WriteLine("Enter the second rovers first location information:");

            secondRoverInformations = Console.ReadLine();

            Rover r2 = new Rover(Convert.ToInt32(secondRoverInformations.Split(" ")[0]), Convert.ToInt32(secondRoverInformations.Split(" ")[1]), secondRoverInformations.Split(" ")[2], maxX, maxY);

            Console.WriteLine("Enter the second rovers act commands:");

            secondRoverActCommands = Console.ReadLine();

            //Move rovers
            r.moveWithCommands(firstRoverActCommands);

            r2.moveWithCommands(secondRoverActCommands);

            Console.WriteLine(r.getRoverPositionInfo());

            Console.WriteLine(r2.getRoverPositionInfo());

            Console.ReadLine();


            // Unit test yazimi ile hic ilgilenmedim ancak kodu kendim test ettim :') 
            




        }
    }
}
