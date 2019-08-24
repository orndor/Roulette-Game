using System;
using System.Collections.Generic;

namespace Roulette_Game
{
    class RouletteWheel
    {

        static public Tuple<int, string, string> Spin()
        {
            Dictionary<int, (string, string)> rouletteWheel = new Dictionary<int, (string, string)>
            {
                {0,("Green", "0") },
                {1,("Red", "1") },
                {2,("Black", "2") },
                {3,("Red", "3") },
                {4,("Black", "4") },
                {5,("Red", "5") },
                {6,("Black", "6") },
                {7,("Red", "7") },
                {8,("Black", "8") },
                {9,("Red", "9") },
                {10,("Black", "10") },
                {11,("Red", "11") },
                {12,("Black", "12") },
                {13,("Red", "13") },
                {14,("Black", "14") },
                {15,("Red", "15") },
                {16,("Black", "16") },
                {17,("Red", "17") },
                {18,("Black", "18") },
                {19,("Red", "19") },
                {20,("Black", "20") },
                {21,("Red", "21") },
                {22,("Black", "22") },
                {23,("Red", "23") },
                {24,("Black", "24") },
                {25,("Black", "25") },
                {26,("Red", "26") },
                {27,("Black", "27") },
                {28,("Red", "28") },
                {29,("Black", "29") },
                {30,("Red", "30") },
                {31,("Black", "31") },
                {32,("Red", "32") },
                {33,("Black", "33") },
                {34,("Red", "34") },
                {35,("Black", "35") },
                {36,("Red", "36") },
                {37,("Green", "00") },

            };

            Random random = new Random();
            var randomNumber = random.Next(0, 38);
            var color = rouletteWheel[randomNumber].Item1;
            var number = rouletteWheel[randomNumber].Item2;
            Console.WriteLine($"The ball stopped on {color} {number}.\n");

            return new Tuple<int, string, string>(randomNumber, color, number);
        }
    }
}
