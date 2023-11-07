using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGMap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Text Based RPG Map");
            Console.WriteLine();

            DisplayMap();

            Console.WriteLine();

            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);

        }

        static char[,] map = new char[,] // The map itelf
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static void DisplayMap() // Display the map chart
        {
            int MapHeight = 12;
            int MapWidth = 30;

            DisplayBorder(MapWidth);
            for (int i = 0; i < MapHeight; i++)
            {
                Console.Write("|"); // Simple border maker
                for (int k = 0; k < MapWidth; k++)
                {
                    SetTextColor(map[i, k]);
                    Console.Write(map[i, k]);
                    Console.ResetColor();
                }
                Console.WriteLine("|"); // Other side of border
            }
            DisplayBorder(MapWidth);
        }

        static void SetTextColor(char TextType) // Should Make different text types like grass and mountains have different colors
        {
            switch (TextType)
            {

            }
        }

        static void DisplayBorder(int size) // Draws the border around the map
        {
            Console.Write("+");
            for (int i = 0; i < size; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}

