using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // string s1 = Console.ReadLine(); // 5 5
            // string s2 = Console.ReadLine(); // 1 2 N
            // string s3 = Console.ReadLine(); // LMLMLMLMM
            // string s4 = Console.ReadLine(); // 3 3 E
            // string s5 = Console.ReadLine(); // MMRMMRMRRM

            string s1 = "5 5";
            string s2 = "1 2 N";
            string s3 = "LMLMLMLMM";
            string s4 = "3 3 E";
            string s5 = "MMRMMRMRRM";

            string[] str = s1.Split(" ");
            int row = Int32.Parse(str[0]);
            int col = Int32.Parse(str[1]);

            Rover rover = new Rover(s2,row,col);
            rover.Move(s3);
            Console.WriteLine(rover.x + " " + rover.y + " " + rover.dir);

            Rover rover1 = new Rover(s4,row,col);
            rover1.Move(s5);
            Console.WriteLine(rover1.x + " " + rover1.y + " " + rover1.dir);
        }
    }
}
