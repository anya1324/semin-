﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        public int rank {  get; set; } //číslo nebo písmeno karty
        public string suit { get; set; } //suit karty

        public void Print()
        {
            string rank = this.rank.ToString();
            if (this.rank == 11) rank = "J";
            if (this.rank == 12) rank = "Q";
            if (this.rank == 13) rank = "K";
            if (this.rank == 14) rank = "A";

            string line = $"{rank} of {suit}"; //vypíše se v konzoli celá karta 
            for (int i = line.Length; i < 15; i++)
            {
                line += " ";
            }
            Console.WriteLine(line);
        }
    }
}