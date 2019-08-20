using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette_Game
{
    class RouletteWheel
    {

        static public int Spin()
        {
            Dictionary<int, (string, string)> rouletteWheel = new Dictionary<int, (string, string)>
            {
                {0,("Green", "00") },
                {1,("Green", "0") },
                {2,("Red", "1") },
                {3,("Black", "2") },
                {4,("Red", "3") },
                {5,("Black", "4") },
                {6,("Red", "5") },
                {7,("Black", "6") },
                {8,("Red", "7") },
                {9,("Black", "8") },
                {10,("Red", "9") },
                {11,("Black", "10") },
                {12,("Red", "11") },
                {13,("Black", "12") },
                {14,("Red", "13") },
                {15,("Black", "14") },
                {16,("Red", "15") },
                {17,("Black", "16") },
                {18,("Red", "17") },
                {19,("Black", "18") },
                {20,("Red", "19") },
                {21,("Black", "20") },
                {22,("Red", "21") },
                {23,("Black", "22") },
                {24,("Red", "23") },
                {25,("Black", "24") },
                {26,("Black", "25") },
                {28,("Red", "26") },
                {29,("Black", "27") },
                {30,("Red", "28") },
                {31,("Black", "29") },
                {32,("Red", "30") },
                {33,("Black", "31") },
                {34,("Red", "32") },
                {35,("Black", "33") },
                {36,("Red", "34") },
                {37,("Black", "35") },
                {38,("Red", "36") },

            };

            Random random = new Random();
            var randomNumber = random.Next(0, 39);
            var color = rouletteWheel[randomNumber].Item1;
            var number = rouletteWheel[randomNumber].Item2;
            Console.WriteLine($"The ball stopped on {color} {number}.");

            return randomNumber;
        }

    }
}
